interface IIOHandler
{
    /// <summary>
    /// Tries to create a file from the path, after the file is created, it closes the file.
    /// </summary>
    /// <param name="path"></param>
    /// <returns>path</returns>
    string CreateFile(string path);

    /// <summary>
    /// Tries to create a file if the file does not exist, after the file is created it writes to the file.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="message"></param>
    /// <returns>success or fail message</returns>
    string WriteToFile(string path, string message);

    /// <summary>
    /// Tries to create a file if the file does not exist, after the file is created it Appends to the file
    /// </summary>
    /// <param name="path"></param>
    /// <param name="message"></param>
    /// <returns>success or fail message</returns>
    string AppendToFile(string path, string message);
}
