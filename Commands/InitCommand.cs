using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("auth", Description = "store token into global user config ~/.df/conf.ini")]
public class InitCommand : ICommand
{
    [CommandParameter(0, Description = "set the auth token")]
    public string Token { get; init; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        Configs.Global.Values["TOKEN"] = Token;
        Configs.Global.Save();

        await console.Output.WriteLineAsync($"Token has been saved to {Configs.Global.ConfigPath}");
    }
}