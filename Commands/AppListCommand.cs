using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Deployf.Cli.Models;
using Newtonsoft.Json;

namespace Deployf.Cli.Commands;

[Command("apps", Description = "list existing apps")]
public class AppListCommand : BaseCommand, ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        var request = CreateRequest(HttpMethod.Get, $"api/application?Page=0&Count=10000");

        try
        {
            var response = await new HttpClient().SendAsync(request);

            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();
            var objectResponse = JsonConvert.DeserializeObject<PageDto<ApplicationSummaryDto>>(stringResult);
            if (objectResponse != null)
            {
                var appsList = objectResponse.Items.Select(x => new { x.Id, x.Name, x.IsRunned }).ToList();
                foreach (var app in appsList)
                {
                    await console.Output.WriteLineAsync($"Id: {app.Id}, Name: {app.Name}, IsRunning: {app.IsRunned}");
                }
            }
        }
        catch (Exception e)
        {
            await console.Output.WriteAsync($"An error occurred: {e}");
        }
    }
}