using DataBaseScript;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the json file:");
        var path = Path.GetFullPath(Console.ReadLine());
        WorkingWithJson.OpenJson(path);

        Console.WriteLine("Upload test data to the database? (y/n)");
        string choicevariable = Console.ReadLine();
        WorkingWithDataBasePostgreSQL.UploadingData(choicevariable, path);

        using (ConnectionDataBase db = new ConnectionDataBase())
        {
            var games = db.Games.ToList();
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Id}|{game.Name}|{game.YearOfRelease}|{game.Genre}|{game.DeveloperStudio}");
            }
        }
    }
}