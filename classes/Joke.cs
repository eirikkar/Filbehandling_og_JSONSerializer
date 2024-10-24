using System.Text.Json;
using System.Text.Json.Serialization;

public class Joke : IJoke
{
    [JsonPropertyName("joke")]
    public string? JokeBody { get; set; }

    public void ExtractJoke(string path)
    {
        try
        {
            Console.Clear();
            string json = File.ReadAllText(path);
            var joke = JsonSerializer.Deserialize<Joke>(json);
            Console.WriteLine(joke?.JokeBody);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
