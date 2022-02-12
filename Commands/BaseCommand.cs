using CliFx.Attributes;
using System.Net.Http.Headers;

public abstract class BaseCommand
{
    [CommandOption("token", IsRequired = true, Description = "set auth token", EnvironmentVariable = "TOKEN")]
    public string Token { get; set; }

    [CommandOption("api-url", Description = "set the url to api", EnvironmentVariable = "API_URL")]
    public string ApiUrl { get; set; } = "https://v2.d-f.pw";

    public HttpRequestMessage CreateRequest(HttpMethod method, string query)
    {
        var request = new HttpRequestMessage();
        request.Method = method;
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        request.RequestUri = new Uri(new Uri(ApiUrl), query);
        return request;
    }

    public async Task ExecSimple(HttpMethod method, string query)
    {
        var request = CreateRequest(method, query);
        var response = await new HttpClient().SendAsync(request);
        response.EnsureSuccessStatusCode();
    }
}
