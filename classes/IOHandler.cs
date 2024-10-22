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
}
