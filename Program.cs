namespace Filbehandling_og_JSONSerializer;

class Program
{
    static void Main(string[] args)
    {
        IOHandler iOHandler = new();
        string path = "test.txt";
        string message = "Hello World!";
        iOHandler.AppendToFile(path, message);
    }
}
