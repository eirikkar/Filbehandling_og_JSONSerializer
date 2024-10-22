namespace Filbehandling_og_JSONSerializer;

class Program
{
    static void Main(string[] args)
    {
        // Creates a new iOHandler instance
        IOHandler iOHandler = new();
        // Path and message
        string path = "test.txt";
        string message = "Hello World!";

        // Appends to file and reads the file to the console.
        iOHandler.AppendToFile(path, message);
        Console.WriteLine(iOHandler.ReadFile(path));
    }
}
