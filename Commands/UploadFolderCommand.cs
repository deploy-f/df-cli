using CliFx;
using CliFx.Attributes;
using CliFx.Exceptions;
using CliFx.Infrastructure;
using System.Diagnostics;
using System.IO.Compression;

[Command("upload-folder", Description = "upload folder to the container")]
public class UploadFolderCommand : ApplicationBaseCommand, ICommand
{
    [CommandParameter(0)]
    public string SourceFolder { get; set; }

    [CommandParameter(1)]
    public string AppPath { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var absolutePath = Path.GetFullPath(SourceFolder);
        if(!Directory.Exists(absolutePath))
        {
            throw new CommandException("Directory does not exist");
        }

        using var tempPath = new TempFSEntry(false);

        ZipFile.CreateFromDirectory(SourceFolder, tempPath, CompressionLevel.SmallestSize, false);

        using var zip = File.OpenRead(tempPath);

        var request = CreateRequest(HttpMethod.Put, $"api/application/{AppId}/exec");
        var content = new MultipartFormDataContent();
        request.Content = content;
        content.Add(new StringContent("bsdtar"), "command");
        content.Add(new StringContent("-xf"), "command");
        content.Add(new StringContent("-"), "command");
        content.Add(new StringContent("-C"), "command");
        content.Add(new StringContent(AppPath), "command");
        content.Add(new StreamContent(zip), "file", "stdin");

        var response = await new HttpClient().SendAsync(request);

        response.EnsureSuccessStatusCode();

        await response.Content.ReadAsStream().CopyToAsync(console.Output.BaseStream);
    }
}

public class TempFSEntry : IDisposable
{
    public readonly string EntryPath;

    private bool _destroyed;
    private bool _isFolder;

    public TempFSEntry(bool isFolder = true)
    {
        var basePath = Path.Combine(Path.GetTempPath(), "deployf");

        if(!Directory.Exists(basePath))
        {
            Directory.CreateDirectory(basePath);
        }

        EntryPath = Path.Combine(basePath, Path.GetRandomFileName());
        _isFolder = isFolder;
        if (isFolder)
        {
            Directory.CreateDirectory(EntryPath);
        }
        Debug.WriteLine($"Allocate temp fs entry at {EntryPath}");
    }

    ~TempFSEntry()
    {
        Dispose();
    }

    public void Dispose()
    {
        if (_destroyed)
        {
            return;
        }

        _destroyed = true;

        if (_isFolder && Directory.Exists(EntryPath))
        {
            Debug.WriteLine($"Dispose temp folder at {EntryPath}");
            Directory.Delete(EntryPath, true);
        }

        if (!_isFolder && File.Exists(EntryPath))
        {
            Debug.WriteLine($"Dispose temp file at {EntryPath}");
            File.Delete(EntryPath);
        }
    }

    public static implicit operator string(TempFSEntry instance)
    {
        return instance.EntryPath;
    }
}