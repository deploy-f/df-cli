using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("logs", Description = "get lines of logs of application")]
public class LogsCommand : ApplicationBaseCommand, ICommand
{
    [CommandOption("tail", IsRequired = false, Description = "how many lines to fetch")]
    public int Tail { get; set; } = 800;

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var request = CreateRequest(HttpMethod.Get, $"api/application/{AppId}/logs?tail={Tail}");
        var response = await new HttpClient().SendAsync(request);
        response.EnsureSuccessStatusCode();
        console.Output.Write(await response.Content.ReadAsStringAsync());
    }
}