using System.Text.Json;

class Car : ICar
{
    public string? name { get; set; }
    public string? model { get; set; }
    public int year { get; set; }

    public void WriteToJsonFile(string path, List<Car>? cars)
    {
        try
        {
            string json = JsonSerializer.Serialize(
                cars,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(path, json);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public List<Car>? ReadFromJsonFile(string path)
    {
        try
        {
            _ = new List<Car>();
            string json = File.ReadAllText(path);
            List<Car>? cars = JsonSerializer.Deserialize<List<Car>>(json);
            return cars;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public void ListAllCars(List<Car>? cars)
    {
        Console.Clear();
        if (cars == null)
        {
            Console.WriteLine("No cars found!");
        }
        else
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Name: {car.name}, Model: {car.model}, Year: {car.year}");
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void AddCar(string JSONpath, Car car, List<Car>? cars)
    {
        Console.Clear();
        Console.WriteLine("Please input a car name: ");
        string? name = Utility.StringParser(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Please input a car model: ");
        string? model = Utility.StringParser(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Please input a car year: ");
        int year = Utility.NumberParser(Console.ReadLine());
        var NewCar = new Car
        {
            name = name,
            model = model,
            year = year,
        };
        cars?.Add(NewCar);
        car.WriteToJsonFile(JSONpath, cars);
        Console.Clear();
        Console.WriteLine("Car added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
