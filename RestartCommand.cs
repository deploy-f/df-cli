using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("restart", Description = "restart the application")]
public class RestartCommand : ApplicationBaseCommand, ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        console.Output.WriteLine($"Stopping {AppId}");
        await ExecSimple(HttpMethod.Put, $"api/application/{AppId}/stop");
        console.Output.WriteLine($"Starting {AppId}");
        await ExecSimple(HttpMethod.Put, $"api/application/{AppId}/start");
        console.Output.WriteLine($"OK");
    }
}