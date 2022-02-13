using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

[Command("login", Description = "login with browser")]
public class LoginCommand : ICommand
{
    [CommandOption("api-url", Description = "set the url to api", EnvironmentVariable = "API_URL")]
    public string ApiUrl { get; set; } = "https://v2.d-f.pw";


    public async ValueTask ExecuteAsync(IConsole console)
    {
        OpenUrl(new Uri(new Uri(ApiUrl), "id/Cli").AbsoluteUri);

        var server = new HttpServer();
        var token = await server.Listen();

        Configs.Global.Values["TOKEN"] = token;
        Configs.Global.Save();

        await console.Output.WriteLineAsync($"Token has been saved to {Configs.Global.ConfigPath}");
    }

    private void OpenUrl(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch
        {
            // hack because of this: https://github.com/dotnet/corefx/issues/10361
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else
            {
                throw;
            }
        }
    }


    class HttpServer
    {
        public const string URL = "http://localhost:35941/";
        public const string PAGE_DATA =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Deployf CLI Login</title>" +
            "  </head>" +
            "  <body>" +
            "    <h1>Logged in</h1>" +
            "    <h2>Close the tab and switch to opened cmd window</h2>" +
            "  </body>" +
            "</html>";

        public HttpListener Listener;


        public async Task<string> HandleIncomingConnections()
        {
            bool runServer = true;
            string token = null;

            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                HttpListenerContext ctx = await Listener.GetContextAsync();
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                if (req.Url.AbsolutePath == "/token")
                {
                    token = req.Url.Query.Substring(1).Trim();
                    runServer = false;
                }

                // Write the response info
                byte[] data = Encoding.UTF8.GetBytes(PAGE_DATA);
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }

            return token;
        }


        public async Task<string> Listen()
        {
            // Create a Http server and start listening for incoming connections
            Listener = new HttpListener();
            Listener.Prefixes.Add(URL);
            Listener.Start();
            Console.WriteLine("Listening for connections on {0}", URL);

            // Handle requests
            var result = await HandleIncomingConnections();

            // Close the listener
            Listener.Close();

            return result;
        }
    }
}