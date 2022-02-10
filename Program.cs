using CliFx;
using System.Diagnostics;

await InitConfig();

await new CliApplicationBuilder()
    .AddCommandsFromThisAssembly()
    .SetExecutableName("df")
    .Build()
    .RunAsync();

static async Task InitConfig()
{
    var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

    try
    {
        var userConfPath = Path.Combine(home, ".df", "conf.ini");
        if (File.Exists(userConfPath))
        {
            var userConf = await File.ReadAllTextAsync(userConfPath);
            ApplyEnv(userConf);
        }

        if (File.Exists(".df.ini"))
        {
            var userConf = await File.ReadAllTextAsync(".df.ini");
            ApplyEnv(userConf);
        }
    }
    catch (Exception ex)
    {
        Debug.WriteLine(ex.ToString());
    }

    void ApplyEnv(string userConf)
    {
        var lines = userConf.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (var line in lines)
        {
            var items = line.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (items.Length == 2)
            {
                Environment.SetEnvironmentVariable(items[0], items[1]);
            }
        }
    }
}