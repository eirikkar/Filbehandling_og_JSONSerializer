using System;
using System.IO;
using System.Text.Json;

class Car
{
    public string? name { get; set; }
    public string? model { get; set; }
    public int year { get; set; }

    public void WriteToJsonFile(string path, List<Car>? cars)
    {
        string json = JsonSerializer.Serialize(
            cars,
            new JsonSerializerOptions { WriteIndented = true }
        );
        File.WriteAllText(path, json);
    }

    public List<Car>? ReadFromJsonFile(string path)
    {
        _ = new List<Car>();
        string json = File.ReadAllText(path);
        List<Car>? cars = JsonSerializer.Deserialize<List<Car>>(json);
        return cars;
    }
}
