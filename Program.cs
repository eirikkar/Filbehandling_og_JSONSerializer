namespace Filbehandling_og_JSONSerializer;

class Program
{
    public static void Main(string[] args)
    {
        //Den første opgaven, jeg la den inn i en metode for å gjøre det lettere å lese
        FirstTask();
        // Path to JSON file
        string JSONpath = "data.json";
        // Instantiating a new Car object and a new list of cars
        Car car = new();
        var cars = car.ReadFromJsonFile(JSONpath);
        Console.WriteLine("Please input a car name: ");
        string? name = Utility.StringParser(Console.ReadLine());
        Console.WriteLine("Please input a car model: ");
        string? model = Utility.StringParser(Console.ReadLine());
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
    }

    private static void FirstTask()
    {
        string path = "test.txt";
        string message = "Hello World!";

        IOHandler iOHandler = new();
        iOHandler.AppendToFile(path, message);
        // Denne er kommentert ut fordi den skriver ut i konsollen
        //Console.WriteLine(iOHandler.ReadFile(path));
    }
}
