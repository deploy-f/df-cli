using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

[Command("exec", Description = "exec command in the app container")]
public class ExecCommand : ApplicationBaseCommand, ICommand
{
    [CommandParameter(0)]
    public string Command { get; set; }

    public async ValueTask ExecuteAsync(IConsole console)
    {
        var request = CreateRequest(HttpMethod.Put, $"api/application/{AppId}/exec");
        var content = new MultipartFormDataContent();
        request.Content = content;

        foreach (var command in ParseCmd(Command))
        {
            content.Add(new StringContent(command), "command");
        }

        if(console.IsInputRedirected)
        {
            content.Add(new StreamContent(console.Input.BaseStream), "file", "stdin");
        }

        var response = await new HttpClient().SendAsync(request);

        response.EnsureSuccessStatusCode();

        await response.Content.ReadAsStream().CopyToAsync(console.Output.BaseStream);
    }

    static IEnumerable<string> ParseCmd(string command)
    {
        if (command.Length == 0)
        {
            yield break;
        }

        var inSubstring = false;
        var start = 0;
        var inEncaps = false;

        for (int i = 0; i < command.Length; i++)
        {
            if (inEncaps)
            {
                inEncaps = false;
                continue;
            }

            var ch = command[i];

            if (inSubstring)
            {
                if (ch == '"' || ch == '\'')
                {
                    inSubstring = false;
                    yield return Trim(command[start..i]);
                    start = i + 1;
                }
                continue;
            }

            if (ch == ' ' || ch == '\t')
            {
                if (i == start || command[start] == ' ' || command[start] == '\t')
                {
                    start = i + 1;
                }
                else
                {
                    yield return Trim(command[start..i]);
                    start = i + 1;
                }
            }
            else if (ch == '"' || ch == '\'')
            {
                inSubstring = true;
                if ((i - start) >= 1)
                {
                    yield return Trim(command[start..i]);
                }
                start = i + 1;
            }
            else if (ch == '\\')
            {
                inEncaps = true;
            }
        }

        if ((command.Length - 1) >= start && command.Last() != '"' && command.Last() != '\'')
        {
            yield return Trim(command.Substring(start));
        }
        else if (start == 0 && command.Length > 0)
        {
            yield return Trim(command.Substring(start));
        }
        else if (start == 0 && command.Length == 1)
        {
            yield return command;
        }

        string Trim(string input)
        {
            return input.Replace("\\'", "'").Replace("\\\"", "\"").Replace("\\\\", "\\");
        }
    }
}