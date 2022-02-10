using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using IO.Swagger.Api;

[Command("upload", Description = "uplaoad file to the container")]
public class UploadFileCommand : ApplicationBaseCommand, ICommand
{

    [CommandParameter(0)]
    public string ContainerPath { get; set; }

    [CommandOption("file")]
    public string SourceFile { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var api = GetApi<ApplicationApi>();

        using Stream file = console.IsInputRedirected ? console.Input.BaseStream : File.OpenRead(SourceFile);

        var response = api.Exec(AppId, new List<string> { "tee", ContainerPath }, file);

        console.Output.BaseStream.Write(response);
    }
}