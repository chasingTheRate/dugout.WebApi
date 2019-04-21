
using Newtonsoft.Json;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models {
     public class Venue
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("link")]
        public string link { get; set; }
    }

    public class League
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("link")]
        public string link { get; set; }
    }

    public class Division
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("link")]
        public string link { get; set; }
    }

    public class Sport
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("link")]
        public string link { get; set; }

        [BsonElement("name")]
        public string name { get; set; }
    }

    public class SpringLeague
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("link")]
        public string link { get; set; }

        [BsonElement("abbreviation")]
        public string abbreviation { get; set; }
    }

    public class Team
    {

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public int id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("link")]
        public string link { get; set; }

        [BsonElement("venue")]
        public Venue venue { get; set; }

        [BsonElement("teamCode")]
        public string teamCode { get; set; }

        [BsonElement("fileCode")]
        public string fileCode { get; set; }

        [BsonElement("abbreviation")]
        public string abbreviation { get; set; }

        [BsonElement("teamName")]
        public string teamName { get; set; }

        [BsonElement("locationName")]
        public string locationName { get; set; }

        [BsonElement("firstYearOfPlay")]
        public string firstYearOfPlay { get; set; }

        [BsonElement("league")]
        public League league { get; set; }

        [BsonElement("division")]
        public Division division { get; set; }

        [BsonElement("sport")]
        public Sport sport { get; set; }

        [BsonElement("shortName")]
        public string shortName { get; set; }

        [BsonElement("springLeague")]
        public SpringLeague springLeague { get; set; }

        [BsonElement("allStarStatus")]
        public string allStarStatus { get; set; }

        [BsonElement("active")]
        public bool active { get; set; }
    }

    public class MlbTeams
    {

        [BsonElement("copyright")]
        public string copyright { get; set; }

        [BsonElement("teams")]
        public IList<Team> teams { get; set; }
    }
}
