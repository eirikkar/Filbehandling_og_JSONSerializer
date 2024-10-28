namespace Filbehandling_og_JSONSerializer;

class Program
{
    static async Task Main(string[] args)
    {
        // Path to JSON file
        string JSONpath = "data/data.json";
        string JokePath = "data/jokes.json";

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
            Console.WriteLine("Main menu");
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
                    TheFirstTask.FirstTask();
                    break;
                case "5":
                    Exit = true;
                    break;
            }
        }
    }
}
