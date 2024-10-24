interface ICar
{
    string? name { get; set; }
    string? model { get; set; }
    int year { get; set; }

    /// <summary>
    /// Writes a list of cars to a JSON file
    /// </summary>
    /// <param name="path"></param>
    /// <param name="cars"></param>
    void WriteToJsonFile(string path, List<Car>? cars);

    /// <summary>
    /// Reads a list of cars from a JSON file
    /// </summary>
    /// <param name="path"></param>
    /// <returns>List of cars</returns>
    List<Car>? ReadFromJsonFile(string path);

    /// <summary>
    /// Lists all cars in a list of cars
    /// </summary>
    /// <param name="cars"></param>
    void ListAllCars(List<Car>? cars);

    /// <summary>
    /// Adds a car to a list of cars
    /// </summary>
    /// <param name="JSONpath"></param>
    /// <param name="car"></param>
    /// <param name="cars"></param>

    void AddCar(string JSONpath, Car car, List<Car>? cars);
}
