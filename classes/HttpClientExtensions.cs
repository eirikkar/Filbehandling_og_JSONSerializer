using System.Net.Http;

public static class HttpClientExtensions
{
    /// <summary>
    /// Gets a joke from the joke API and writes it to a file
    /// </summary>
    /// <param name="httpClient"></param>
    /// <param name="jokePath"></param>
    /// <returns></returns>
    public static async Task GetJokes(this System.Net.Http.HttpClient httpClient, string jokePath)
    {
        try
        {
            var response = await httpClient.GetStringAsync(
                "https://v2.jokeapi.dev/joke/Programming?type=single"
            );

            await File.WriteAllTextAsync(jokePath, response);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
