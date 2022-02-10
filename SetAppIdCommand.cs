using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using IO.Swagger.Api;

[Command("set-app-id", Description = "set context to use passed app id")]
public class SetAppIdCommand : ApplicationBaseCommand, ICommand
{
    [CommandParameter(0)]
    public int appId { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var content = File.Exists(".df.ini") ? await File.ReadAllTextAsync(".df.ini") : "";
        var data = new Dictionary<string, string>();
        var lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (var line in lines)
        {
            var items = line.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (items.Length == 2)
            {
                data[items[0]] = items[1];
            }
        }

        data["APP_ID"] = appId.ToString();

        var resultContent = string.Join("\n", data.Select(x => $"{x.Key}={x.Value}"));
        await File.WriteAllTextAsync(".df.ini", resultContent);
        console.Output.WriteLine("OK");
    }
}
