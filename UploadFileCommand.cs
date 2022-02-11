using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using System.Net.Http.Headers;

[Command("upload", Description = "uplaoad file to the container")]
public class UploadFileCommand : ApplicationBaseCommand, ICommand
{
    [CommandParameter(0)]
    public string ContainerPath { get; set; }

    [CommandOption("file")]
    public string SourceFile { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        using Stream file = console.IsInputRedirected ? console.Input.BaseStream : File.OpenRead(SourceFile);

        var request = CreateRequest(HttpMethod.Put, $"api/application/{AppId}/exec");
        var content = new MultipartFormDataContent();
        request.Content = content;
        content.Add(new StringContent("tee"), "command");
        content.Add(new StringContent(ContainerPath), "command");
        content.Add(new StreamContent(file), "file", "stdin");

        var response = await new HttpClient().SendAsync(request);

        response.EnsureSuccessStatusCode();

        await response.Content.ReadAsStream().CopyToAsync(console.Output.BaseStream);
    }
}