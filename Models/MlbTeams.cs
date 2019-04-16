
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dugout.WebApi.Models {
     public class Venue
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class League
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Division
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Sport
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class SpringLeague
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("abbreviation")]
        public string abbreviation { get; set; }
    }

    public class Team
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("venue")]
        public Venue venue { get; set; }

        [JsonProperty("teamCode")]
        public string teamCode { get; set; }

        [JsonProperty("fileCode")]
        public string fileCode { get; set; }

        [JsonProperty("abbreviation")]
        public string abbreviation { get; set; }

        [JsonProperty("teamName")]
        public string teamName { get; set; }

        [JsonProperty("locationName")]
        public string locationName { get; set; }

        [JsonProperty("firstYearOfPlay")]
        public string firstYearOfPlay { get; set; }

        [JsonProperty("league")]
        public League league { get; set; }

        [JsonProperty("division")]
        public Division division { get; set; }

        [JsonProperty("sport")]
        public Sport sport { get; set; }

        [JsonProperty("shortName")]
        public string shortName { get; set; }

        [JsonProperty("springLeague")]
        public SpringLeague springLeague { get; set; }

        [JsonProperty("allStarStatus")]
        public string allStarStatus { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }
    }

    public class MlbTeams
    {

        [JsonProperty("copyright")]
        public string copyright { get; set; }

        [JsonProperty("teams")]
        public IList<Team> teams { get; set; }
    }
}
