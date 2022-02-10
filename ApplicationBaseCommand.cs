using CliFx.Attributes;

public abstract class ApplicationBaseCommand : BaseCommand
{
    [CommandOption("app-id", Description = "set application id", EnvironmentVariable = "APP_ID")]
    public int AppId { get; set; }
}
