interface IJoke
{
    public string? JokeBody { get; set; }

    /// <summary>
    /// Extracts joke from json file to Joke object, and writes joke to console
    /// </summary>
    /// <param name="path"></param>
    void ExtractJoke(string path);
}
