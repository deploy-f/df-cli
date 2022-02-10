using CliFx.Attributes;
using IO.Swagger.Client;

public abstract class BaseCommand
{
    [CommandOption("token", Description = "set auth token", EnvironmentVariable = "TOKEN")]
    public string Token { get; set; }

    [CommandOption("api-url", Description = "set the url to api", EnvironmentVariable = "API_URL")]
    public string ApiUrl { get; set; } = "https://staging.v2.d-f.pw";

    protected T GetApi<T>()
    {
        Configuration.DefaultApiClient.RestClient.BaseUrl = ApiUrl;
        Configuration.ApiKey["Authorization"] = Token;
        Configuration.ApiKeyPrefix["Authorization"] = "Bearer";

        return (T)typeof(T).GetConstructor(new [] { typeof(ApiClient) }).Invoke(new object[] { null });
    }
}
