using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Spectre.Console;

[Command("info", Description = "show configuration info")]
public class ConfigShowCommand : ICommand
{
    public ValueTask ExecuteAsync(IConsole console)
    {
        ShowConfig(Configs.Global);
        ShowConfig(Configs.Local);

        return ValueTask.CompletedTask;
    }

    private static void ShowConfig(Configs config)
    {
        var table = new Table();

        table.AddColumn("Key");
        table.AddColumn("Value");

        foreach (var item in config.Values)
        {
            table.AddRow(item.Key, item.Value);
        }
        AnsiConsole.Write(new Markup($"Config at [red]{config.ConfigPath}[/]\n"));
        AnsiConsole.Write(table);
    }
}