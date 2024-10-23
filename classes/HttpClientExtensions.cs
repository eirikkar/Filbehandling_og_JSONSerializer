using System.Net.Http;

public static class HttpClientExtensions
{
    public static async Task GetJokes(this System.Net.Http.HttpClient httpClient, string jokePath)
    {
        var response = await httpClient.GetStringAsync(
            "https://v2.jokeapi.dev/joke/Programming?type=single"
        );

        await File.WriteAllTextAsync(jokePath, response);
    }
}
