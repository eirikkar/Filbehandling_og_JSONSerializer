class Utility
{
    public static int NumberParser(string? input)
    {
        int num;
        while (!int.TryParse(input, out num))
        {
            Console.Write("Please input a valid number: ");
            input = Console.ReadLine();
        }
        return num;
    }

    public static string? StringParser(string? input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Please input a valid string: ");
            input = Console.ReadLine();
        }
        return input;
    }
}
