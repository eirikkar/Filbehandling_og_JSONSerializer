using System.Text.Json;
using System.Text.Json.Serialization;

public class Joke
{
    [JsonPropertyName("joke")]
    public string? JokeBody { get; set; }

    public void ExtractJoke(string path)
    {
        string json = File.ReadAllText(path);
        var joke = JsonSerializer.Deserialize<Joke>(json);
        Console.WriteLine(joke.JokeBody);
    }
}
