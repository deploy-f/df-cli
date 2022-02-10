using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("init", Description = "store token into global user config ~/.df/conf.ini")]
public class InitCommand : ICommand
{
    [CommandParameter(0, Description = "set the auth token")]
    public string Token { get; init; }

    [CommandOption("api-url", Description = "set the url to api")]
    public string ApiUrl { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var dfPath = Path.Combine(home, ".df");
        if (!Directory.Exists(dfPath))
        {
            Directory.CreateDirectory(dfPath);
        }

        var confPath = Path.Combine(dfPath, "conf.ini");

        var config = $"TOKEN={Token}";
        if(!string.IsNullOrEmpty(ApiUrl))
        {
            config += $"\nAPI_URL={ApiUrl}";
        }

        File.WriteAllText(confPath, config);

        console.Output.WriteLine($"config has been saved to {confPath}");
    }
}