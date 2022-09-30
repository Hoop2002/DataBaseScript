using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseScript
{
    class WorkingWithJson
    {
        internal static void OpenJson(string p)
        {
            var json = File.ReadAllText(p);
            var gameobject = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.GamesJson> (json);

            try
            {
                for(int i = 0; i < gameobject.Games.Length; i++)
                {
                    string name = gameobject.Games[i].Name;
                    string yearofrealease = gameobject.Games[i].YearOfRelease;
                    string genre = gameobject.Games[i].Genre;
                    string developerstudio = gameobject.Games[i].DeveloperStudio;

                    string output = String.Format("\nGame - {0}\nYears of realease - {1}\nGenre - {2}\nStudio - {3}", name, yearofrealease, genre, developerstudio);
                    
                    Console.WriteLine(output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            

        }
    }
}
