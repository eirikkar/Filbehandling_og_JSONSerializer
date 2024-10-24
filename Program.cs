namespace Filbehandling_og_JSONSerializer;

class Program
{
    public static async Task Main(string[] args)
    {
        //Den første opgaven la jeg la den inn i en metode for å gjøre det lettere å lese

        // Path to JSON file
        string JSONpath = "data.json";
        string JokePath = "jokes.json";

        // Instantiating a new Car object and a new list of cars
        Car car = new();
        var cars = car.ReadFromJsonFile(JSONpath);

        // Instantiating a new HttpClient object and a new Joke object
        using HttpClient client = new();
        Joke joke = new();

        // Main menu loop
        bool Exit = false;
        while (!Exit)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. List all cars");
            Console.WriteLine("3. Show a joke");
            Console.WriteLine("4. First task");
            Console.WriteLine("5. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    car.AddCar(JSONpath, car, cars);
                    break;
                case "2":
                    car.ListAllCars(cars);
                    break;
                case "3":
                    await HttpClientExtensions.GetJokes(client, JokePath);
                    joke.ExtractJoke(JokePath);
                    break;
                case "4":
                    FirstTask();
                    break;
                case "5":
                    Exit = true;
                    break;
            }
        }
    }

    private static void FirstTask()
    {
        Console.Clear();
        string path = "test.txt";
        Console.WriteLine("Please input a message to write to the file: ");
        string? message = Utility.StringParser(Console.ReadLine());

        IOHandler iOHandler = new();
        iOHandler.WriteToFile(path, message);
        Console.WriteLine();
        Console.WriteLine("Successfully written to file: ");
        Console.WriteLine(iOHandler.ReadFile(path));
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
