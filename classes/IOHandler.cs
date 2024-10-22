class IOHandler : IIOHandler
{
    public string CreateFile(string path)
    {
        try
        {
            var file = File.Create(path);
            file.Close();
            return path;
        }
        catch (Exception e)
        {
            return $"An error occured {e.Message}";
        }
    }

    public string WriteToFile(string path, string message)
    {
        try
        {
            if (!File.Exists(path))
            {
                CreateFile(path);
            }
            File.WriteAllText(path, message);
            return "Successfully written to file";
        }
        catch (Exception e)
        {
            return $"An error occured {e.Message}";
        }
    }

    public string AppendToFile(string path, string message)
    {
        try
        {
            if (!File.Exists(path))
            {
                CreateFile(path);
            }
            File.AppendAllText(path, message);
            return "Successfully written to file";
        }
        catch (Exception e)
        {
            return $"An error occured {e.Message}";
        }
    }

    public string ReadFile(string path)
    {
        if (!File.Exists(path))
        {
            return "File does not exist.";
        }
        string[] messages = File.ReadAllLines(path);
        try
        {
            if (!messages.Any() || messages == null)
            {
                return "File is empty";
            }

            foreach (string message in messages)
            {
                return message;
            }
        }
        catch (Exception e)
        {
            return $"Error reading the content of the file {path} {e.Message}";
        }
        return "Unknown error occured";
    }
}
