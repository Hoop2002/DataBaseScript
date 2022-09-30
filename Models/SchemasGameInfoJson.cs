using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseScript.Models
{

    public class GamesJson
    {
        [Newtonsoft.Json.JsonProperty("Games")]
        public GameInfo[]? Games { get; set; }
    }

    public class GameInfo
    {
     
        [Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        [Newtonsoft.Json.JsonProperty("yearofrelease")] 
        public string? YearOfRelease { get; set; }

        [Newtonsoft.Json.JsonProperty("genre")]
        public string? Genre { get; set; }

        [Newtonsoft.Json.JsonProperty("developerstudio")]
        public string? DeveloperStudio { get; set; }
    }
}
