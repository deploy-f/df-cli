using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Deployf.Cli.Models;
using Spectre.Console;
using System.Text.Json;

namespace Deployf.Cli.Commands;

[Command("apps", Description = "list existing apps")]
public class AppListCommand : BaseCommand, ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        var request = CreateRequest(HttpMethod.Get, $"api/application?Page=0&Count=10000");

        var response = await new HttpClient().SendAsync(request);

        response.EnsureSuccessStatusCode();

        var stringResult = await response.Content.ReadAsStringAsync();
        var objectResponse = JsonSerializer.Deserialize<PageDto<ApplicationSummaryDto>>(stringResult, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

        var table = new Table();
        table.Border(TableBorder.MinimalDoubleHead);

        table.AddColumn("Id");
        table.AddColumn("Name");
        table.AddColumn("Status");

        foreach (var app in objectResponse.Items)
        {
            table.AddRow(
                new Markup(app.Id.ToString()),
                new Markup(app.Name),
                app.IsRunned ? new Markup("[green]Runnging[/]") : new Markup("Stopped")
            );
        }

        AnsiConsole.Write(table);
    }
}