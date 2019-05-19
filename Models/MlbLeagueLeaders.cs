using Newtonsoft.Json;
using System.Collections.Generic;

namespace dugout.WebApi.Models {
    public class GameType
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

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

        [JsonProperty("season")]
        public int season { get; set; }

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

    public class PrimaryPosition
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("abbreviation")]
        public string abbreviation { get; set; }
    }

    public class BatSide
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    public class PitchHand
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    public class Person
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("primaryNumber")]
        public string primaryNumber { get; set; }

        [JsonProperty("birthDate")]
        public string birthDate { get; set; }

        [JsonProperty("currentAge")]
        public int currentAge { get; set; }

        [JsonProperty("birthCity")]
        public string birthCity { get; set; }

        [JsonProperty("birthCountry")]
        public string birthCountry { get; set; }

        [JsonProperty("height")]
        public string height { get; set; }

        [JsonProperty("weight")]
        public int weight { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }

        [JsonProperty("primaryPosition")]
        public PrimaryPosition primaryPosition { get; set; }

        [JsonProperty("useName")]
        public string useName { get; set; }

        [JsonProperty("boxscoreName")]
        public string boxscoreName { get; set; }

        [JsonProperty("nickName")]
        public string nickName { get; set; }

        [JsonProperty("mlbDebutDate")]
        public string mlbDebutDate { get; set; }

        [JsonProperty("batSide")]
        public BatSide batSide { get; set; }

        [JsonProperty("pitchHand")]
        public PitchHand pitchHand { get; set; }

        [JsonProperty("nameFirstLast")]
        public string nameFirstLast { get; set; }

        [JsonProperty("nameSlug")]
        public string nameSlug { get; set; }

        [JsonProperty("firstLastName")]
        public string firstLastName { get; set; }

        [JsonProperty("lastFirstName")]
        public string lastFirstName { get; set; }

        [JsonProperty("lastInitName")]
        public string lastInitName { get; set; }

        [JsonProperty("initLastName")]
        public string initLastName { get; set; }

        [JsonProperty("fullFMLName")]
        public string fullFMLName { get; set; }

        [JsonProperty("fullLFMName")]
        public string fullLFMName { get; set; }

        [JsonProperty("strikeZoneTop")]
        public double strikeZoneTop { get; set; }

        [JsonProperty("strikeZoneBottom")]
        public double strikeZoneBottom { get; set; }

        [JsonProperty("birthStateProvince")]
        public string birthStateProvince { get; set; }

        [JsonProperty("middleName")]
        public string middleName { get; set; }

        [JsonProperty("draftYear")]
        public int? draftYear { get; set; }

        [JsonProperty("pronunciation")]
        public string pronunciation { get; set; }
    }

    public class Leader
    {

        [JsonProperty("rank")]
        public int rank { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("team")]
        public Team team { get; set; }

        [JsonProperty("league")]
        public League league { get; set; }

        [JsonProperty("person")]
        public Person person { get; set; }

        [JsonProperty("sport")]
        public Sport sport { get; set; }

        [JsonProperty("season")]
        public string season { get; set; }
    }

    public class LeagueLeader
    {

        [JsonProperty("leaderCategory")]
        public string leaderCategory { get; set; }

        [JsonProperty("season")]
        public string season { get; set; }

        [JsonProperty("gameType")]
        public GameType gameType { get; set; }

        [JsonProperty("leaders")]
        public IList<Leader> leaders { get; set; }

        [JsonProperty("statGroup")]
        public string statGroup { get; set; }
    }

    public class MlbLeagueLeaders
    {

        [JsonProperty("copyright")]
        public string copyright { get; set; }

        [JsonProperty("leagueLeaders")]
        public IList<LeagueLeader> leagueLeaders { get; set; }
    }
}
