namespace Filbehandling_og_JSONSerializer;

class Program
{
    public static async Task Main(string[] args)
    {
        //Den første opgaven la jeg la den inn i en metode for å gjøre det lettere å lese
        FirstTask();
        //https://v2.jokeapi.dev/joke/Programming?type=single
        // Path to JSON file
        string JSONpath = "data.json";
        string JokePath = "jokes.json";
        // Instantiating a new Car object and a new list of cars
        Car car = new();
        var cars = car.ReadFromJsonFile(JSONpath);

        using HttpClient client = new();
        await HttpClientExtensions.GetJokes(client, JokePath);
        Joke joke = new();
        joke.ExtractJoke(JokePath);
        // Main menu loop
        // bool Exit = false;
        // while (!Exit)
        // {
        //     Console.Clear();
        //     Console.WriteLine("Main Menu");
        //     Console.WriteLine("1. Add Car");
        //     Console.WriteLine("2. List all cars");
        //     Console.WriteLine("3. Not implemented");
        //     Console.WriteLine("4. Not implemented");
        //     Console.WriteLine("5. Exit");
        //     switch (Console.ReadLine())
        //     {
        //         case "1":
        //             car.AddCar(JSONpath, car, cars);
        //             break;
        //         case "2":
        //             car.ListAllCars(cars);
        //             break;
        //         case "3":

        //             break;
        //         case "4":

        //             break;
        //         case "5":
        //             Exit = true;
        //             break;
        //     }
        // }
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
