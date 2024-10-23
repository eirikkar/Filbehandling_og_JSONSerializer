class Utility
{
    /// <summary>
    /// Parses a string input to an integer.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns a valid number, num</returns>
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

    /// <summary>
    /// Parses a string input, checks if the string is null or whitespace.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>string input</returns>
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
