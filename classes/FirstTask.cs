class TheFirstTask
{
    /// <summary>
    /// Function that contains the first task
    /// </summary>
    public static void FirstTask()
    {
        Console.Clear();
        string path = "data/test.txt";
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
