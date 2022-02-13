using CliFx;

Configs.Global.Apply();
Configs.Local.Apply();

await new CliApplicationBuilder()
    .AddCommandsFromThisAssembly()
    .SetExecutableName("deployf")
    .SetTitle("Deploy-f cli")
    .Build()
    .RunAsync();