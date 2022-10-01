using Microsoft.EntityFrameworkCore;
using DataBaseScript.Models;

namespace DataBaseScript
{
    internal class WorkingWithDataBasePostgreSQL 
    {
        internal static void UploadingData(string cv, string p) 
        {


            var json = File.ReadAllText(p);
            var gameobject = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.GamesJson>(json);

            switch (cv)
            {
                case "y":
                    using (ConnectionDataBase db = new ConnectionDataBase())
                    {

                        for(int i = 0; i < gameobject.Games.Length; i++)
                        {
                            string name = gameobject.Games[i].Name;
                            string yearofrealease = gameobject.Games[i].YearOfRelease;
                            string genre = gameobject.Games[i].Genre;
                            string developerstudio = gameobject.Games[i].DeveloperStudio;

                            var game = new GameInfoSqlSchema 
                            {
                              Name = name, 
                              YearOfRelease = yearofrealease, 
                              Genre = genre,
                              DeveloperStudio = developerstudio
                            };
                            db.Games.Add(game);
                            db.SaveChanges();
                            Console.WriteLine("Data uploaded");
                        }
                    }
                   
                    break;
                case "n":
                    Console.WriteLine("The data was not uploaded");
                    break;
                default:
                    Console.WriteLine("There is no such option");
                    break;
            }
        }
    }
}
