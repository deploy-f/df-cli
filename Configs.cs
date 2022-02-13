using System.Diagnostics;

public class Configs
{
    private const string DEPLOYF_HOME_FOLDER = ".df";
    private const string GLOBAL_CONFIG_NAME = "conf.ini";

    public readonly Dictionary<string, string> Values = new ();
    public readonly string ConfigPath;

    public Configs(string configPath)
    {
        ConfigPath = Path.GetFullPath(configPath!);

        if (File.Exists(configPath))
        {
            var lines = File.ReadAllLines(configPath);
            foreach (var line in lines)
            {
                var items = line.Split('=', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                if (items.Length == 2)
                {
                    Values[items[0]] = items[1];
                }
            }

            Debug.WriteLine($"Config {ConfigPath} has ben loaded");
        }
    }

    public void Apply()
    {
        foreach (var item in Values)
        {
            Environment.SetEnvironmentVariable(item.Key, item.Value);
            Debug.WriteLine($"Setting env var {item.Key}={item.Value}");
        }
    }

    public void Save()
    {
        var content = "";
        foreach (var item in Values)
        {
            content += $"{item.Key}={item.Value}";
        }

        var basePath = Path.GetDirectoryName(ConfigPath);
        if(!Directory.Exists(basePath))
        {
            Directory.CreateDirectory(basePath);
            Debug.WriteLine($"Directory {basePath} had been created");
        }

        File.WriteAllText(ConfigPath, content);

        Debug.WriteLine($"Config has been saved to {ConfigPath}\nContent:\n{content}");
    }

    private static Configs _global;
    public static Configs Global
    {
        get {
            if(_global == null)
            {
                _global = new Configs(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                        DEPLOYF_HOME_FOLDER,
                        GLOBAL_CONFIG_NAME
                    )
                );
            }

            return _global;
        }
    }

    private static Configs _local;
    public static Configs Local
    {
        get
        {
            if (_local == null)
            {
                _local = new Configs(Path.GetFullPath(".df.ini"));
            }

            return _local;
        }
    }
}