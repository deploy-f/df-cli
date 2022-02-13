using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("set", Description = "set config to local or global config file")]
public class ConfigSetCommand : ICommand
{
    [CommandParameter(0, Description = "the parameter name", IsRequired = true)]
    public Parameter Param { get; init; }

    [CommandParameter(1, Description = "the new value", IsRequired = false)]
    public string Value { get; set; } = "";

    [CommandOption("clear", Description = "clear the parameter")]
    public bool Clear { get; set; } = false;

    [CommandOption("target", Description = "Local or Global config file")]
    public ConfigTarget Target { get; set; } = ConfigTarget.Local;

    public ValueTask ExecuteAsync(IConsole console)
    {
        var config = Target == ConfigTarget.Global ? Configs.Global : Configs.Local;

        var key = Param switch
        {
            Parameter.AppId => "APP_ID",
            Parameter.ApiUrl => "API_URL",
            Parameter.Token => "TOKEN",
            _ => throw new NotImplementedException(Param.ToString())
        };

        if(Clear)
        {
            if(config.Values.ContainsKey(key))
            {
                config.Values.Remove(key);
            }
        }
        else
        {
            config.Values[key] = Value;
        }

        config.Save();

        return ValueTask.CompletedTask;
    }

    public enum ConfigTarget
    {
        Local,
        Global
    }

    public enum Parameter
    {
        AppId,
        ApiUrl,
        Token
    }
}