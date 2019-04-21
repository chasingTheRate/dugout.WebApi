using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models {
  public class BoxscoreVenue
  {

    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("link")]
    public string link { get; set; }
  }

    public class BoxscoreLeague
    {
      [JsonProperty("id")]
      public int id { get; set; }

      [JsonProperty("name")]
      public string name { get; set; }

      [JsonProperty("link")]
      public string link { get; set; }
    }

    public class BoxscoreDivision
    {

      [JsonProperty("id")]
      public int id { get; set; }

      [JsonProperty("name")]
      public string name { get; set; }

      [JsonProperty("link")]
      public string link { get; set; }
    }

    public class BoxscoreSport
    {

      [JsonProperty("id")]
      public int id { get; set; }

      [JsonProperty("link")]
      public string link { get; set; }

      [JsonProperty("name")]
      public string name { get; set; }
    }

    public class BoxscoreLeagueRecord
    {

      [JsonProperty("wins")]
      public int wins { get; set; }

      [JsonProperty("losses")]
      public int losses { get; set; }

      [JsonProperty("pct")]
      public string pct { get; set; }
    }

    public class Records {

    }
    public class Record
    {

      [JsonProperty("gamesPlayed")]
      public int gamesPlayed { get; set; }

      [JsonProperty("wildCardGamesBack")]
      public string wildCardGamesBack { get; set; }

      [JsonProperty("leagueGamesBack")]
      public string leagueGamesBack { get; set; }

      [JsonProperty("springLeagueGamesBack")]
      public string springLeagueGamesBack { get; set; }

      [JsonProperty("sportGamesBack")]
      public string sportGamesBack { get; set; }

      [JsonProperty("divisionGamesBack")]
      public string divisionGamesBack { get; set; }

      [JsonProperty("conferenceGamesBack")]
      public string conferenceGamesBack { get; set; }

      [JsonProperty("leagueRecord")]
      public BoxscoreLeagueRecord leagueRecord { get; set; }

      [JsonProperty("records")]
      public Records records { get; set; }

      [JsonProperty("divisionLeader")]
      public bool divisionLeader { get; set; }

      [JsonProperty("wins")]
      public int wins { get; set; }

      [JsonProperty("losses")]
      public int losses { get; set; }

      [JsonProperty("winningPercentage")]
      public string winningPercentage { get; set; }
    }

    public class BoxscoreSpringLeague
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

    public class BoxscoreTeam
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
      public BoxscoreVenue venue { get; set; }

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
      public BoxscoreLeague league { get; set; }

      [JsonProperty("division")]
      public BoxscoreDivision division { get; set; }

      [JsonProperty("sport")]
      public BoxscoreSport sport { get; set; }

      [JsonProperty("shortName")]
      public string shortName { get; set; }

      [JsonProperty("record")]
      public Record record { get; set; }

      [JsonProperty("springLeague")]
      public BoxscoreSpringLeague springLeague { get; set; }

      [JsonProperty("allStarStatus")]
      public string allStarStatus { get; set; }

      [JsonProperty("active")]
      public bool active { get; set; }
    }

    public class Batting
    {

      [JsonProperty("flyOuts")]
      public int flyOuts { get; set; }

      [JsonProperty("groundOuts")]
      public int groundOuts { get; set; }

      [JsonProperty("runs")]
      public int runs { get; set; }

      [JsonProperty("doubles")]
      public int doubles { get; set; }

      [JsonProperty("triples")]
      public int triples { get; set; }

      [JsonProperty("homeRuns")]
      public int homeRuns { get; set; }

      [JsonProperty("strikeOuts")]
      public int strikeOuts { get; set; }

      [JsonProperty("baseOnBalls")]
      public int baseOnBalls { get; set; }

      [JsonProperty("intentionalWalks")]
      public int intentionalWalks { get; set; }

      [JsonProperty("hits")]
      public int hits { get; set; }

      [JsonProperty("hitByPitch")]
      public int hitByPitch { get; set; }

      [JsonProperty("avg")]
      public string avg { get; set; }

      [JsonProperty("atBats")]
      public int atBats { get; set; }

      [JsonProperty("obp")]
      public string obp { get; set; }

      [JsonProperty("slg")]
      public string slg { get; set; }

      [JsonProperty("ops")]
      public string ops { get; set; }

      [JsonProperty("caughtStealing")]
      public int caughtStealing { get; set; }

      [JsonProperty("stolenBases")]
      public int stolenBases { get; set; }

      [JsonProperty("groundIntoDoublePlay")]
      public int groundIntoDoublePlay { get; set; }

      [JsonProperty("groundIntoTriplePlay")]
      public int groundIntoTriplePlay { get; set; }

      [JsonProperty("totalBases")]
      public int totalBases { get; set; }

      [JsonProperty("rbi")]
      public int rbi { get; set; }

      [JsonProperty("leftOnBase")]
      public int leftOnBase { get; set; }

      [JsonProperty("sacBunts")]
      public int sacBunts { get; set; }

      [JsonProperty("sacFlies")]
      public int sacFlies { get; set; }

      [JsonProperty("catchersInterference")]
      public int catchersInterference { get; set; }

      [JsonProperty("pickoffs")]
      public int pickoffs { get; set; }
    }

    public class Pitching
    {

      [JsonProperty("groundOuts")]
      public int groundOuts { get; set; }

      [JsonProperty("runs")]
      public int runs { get; set; }

      [JsonProperty("doubles")]
      public int doubles { get; set; }

      [JsonProperty("triples")]
      public int triples { get; set; }

      [JsonProperty("homeRuns")]
      public int homeRuns { get; set; }

      [JsonProperty("strikeOuts")]
      public int strikeOuts { get; set; }

      [JsonProperty("baseOnBalls")]
      public int baseOnBalls { get; set; }

      [JsonProperty("intentionalWalks")]
      public int intentionalWalks { get; set; }

      [JsonProperty("hits")]
      public int hits { get; set; }

      [JsonProperty("atBats")]
      public int atBats { get; set; }

      [JsonProperty("caughtStealing")]
      public int caughtStealing { get; set; }

      [JsonProperty("stolenBases")]
      public int stolenBases { get; set; }

      [JsonProperty("era")]
      public string era { get; set; }

      [JsonProperty("inningsPitched")]
      public string inningsPitched { get; set; }

      [JsonProperty("saveOpportunities")]
      public int saveOpportunities { get; set; }

      [JsonProperty("earnedRuns")]
      public int earnedRuns { get; set; }

      [JsonProperty("whip")]
      public string whip { get; set; }

      [JsonProperty("battersFaced")]
      public int battersFaced { get; set; }

      [JsonProperty("outs")]
      public int outs { get; set; }

      [JsonProperty("completeGames")]
      public int completeGames { get; set; }

      [JsonProperty("shutouts")]
      public int shutouts { get; set; }

      [JsonProperty("hitBatsmen")]
      public int hitBatsmen { get; set; }

      [JsonProperty("wildPitches")]
      public int wildPitches { get; set; }

      [JsonProperty("pickoffs")]
      public int pickoffs { get; set; }

      [JsonProperty("airOuts")]
      public int airOuts { get; set; }

      [JsonProperty("rbi")]
      public int rbi { get; set; }

      [JsonProperty("inheritedRunners")]
      public int inheritedRunners { get; set; }

      [JsonProperty("inheritedRunnersScored")]
      public int inheritedRunnersScored { get; set; }

      [JsonProperty("catchersInterference")]
      public int catchersInterference { get; set; }

      [JsonProperty("sacBunts")]
      public int sacBunts { get; set; }

      [JsonProperty("sacFlies")]
      public int sacFlies { get; set; }
    }

    public class Fielding
    {

      [JsonProperty("assists")]
      public int assists { get; set; }

      [JsonProperty("putOuts")]
      public int putOuts { get; set; }

      [JsonProperty("errors")]
      public int errors { get; set; }

      [JsonProperty("chances")]
      public int chances { get; set; }

      [JsonProperty("caughtStealing")]
      public int caughtStealing { get; set; }

      [JsonProperty("passedBall")]
      public int passedBall { get; set; }

      [JsonProperty("stolenBases")]
      public int stolenBases { get; set; }

      [JsonProperty("stolenBasePercentage")]
      public string stolenBasePercentage { get; set; }

      [JsonProperty("pickoffs")]
      public int pickoffs { get; set; }
    }

    public class TeamStats
    {

      [JsonProperty("batting")]
      public Batting batting { get; set; }

      [JsonProperty("pitching")]
      public Pitching pitching { get; set; }

      [JsonProperty("fielding")]
      public Fielding fielding { get; set; }
    }

    public class BoxscorePerson
    {

      [JsonProperty("id")]
      public int id { get; set; }

      [JsonProperty("fullName")]
      public string fullName { get; set; }

      [JsonProperty("link")]
      public string link { get; set; }
    }

    public class BoxscorePosition
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

    public class Stats
    {

        [JsonProperty("batting")]
        public  Batting batting { get; set; }

        [JsonProperty("pitching")]
        public  Pitching pitching { get; set; }

        [JsonProperty("fielding")]
        public  Fielding fielding { get; set; }
    }

    public class BoxscoreStatus
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    public class SeasonStats
    {

        [JsonProperty("batting")]
        public  Batting batting { get; set; }

        [JsonProperty("pitching")]
        public  Pitching pitching { get; set; }

        [JsonProperty("fielding")]
        public  Fielding fielding { get; set; }
    }

    public class GameStatus
    {

        [JsonProperty("isCurrentBatter")]
        public bool isCurrentBatter { get; set; }

        [JsonProperty("isCurrentPitcher")]
        public bool isCurrentPitcher { get; set; }

        [JsonProperty("isOnBench")]
        public bool isOnBench { get; set; }

        [JsonProperty("isSubstitute")]
        public bool isSubstitute { get; set; }
    }

    public class AllPosition
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
    public class BoxscorePlayer
    {

        [JsonProperty("person")]
        public BoxscorePerson person { get; set; }

        [JsonProperty("jerseyNumber")]
        public string jerseyNumber { get; set; }

        [JsonProperty("position")]
        public BoxscorePosition position { get; set; }

        [JsonProperty("stats")]
        public Stats stats { get; set; }

        [JsonProperty("status")]
        public BoxscoreStatus status { get; set; }

        [JsonProperty("parentTeamId")]
        public int parentTeamId { get; set; }

        [JsonProperty("battingOrder")]
        public string battingOrder { get; set; }

        [JsonProperty("seasonStats")]
        public SeasonStats seasonStats { get; set; }

        [JsonProperty("gameStatus")]
        public GameStatus gameStatus { get; set; }

        [JsonProperty("allPositions")]
        public IList<AllPosition> allPositions { get; set; }
    }

    
    public class Players
    {
      public Players() {
        players = new List<BoxscorePlayer>();
      }
      [JsonExtensionData]
      private IDictionary<string, JToken> _data { get; set; }
      public List<BoxscorePlayer> players { get; set; }

      [OnDeserialized]
      private void OnDeserialized(StreamingContext context)
      {
        foreach(KeyValuePair<string, JToken> entry in _data)
        {
          var boxscorePlayer = entry.Value.ToObject<BoxscorePlayer>();
          players.Add(boxscorePlayer);
        } 
      }
    }

    public class Info
    {

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("fieldList")]
        public IList<FieldList> fieldList { get; set; }
    }

    public class Note
    {

        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class BoxscoreAway
    {

        [JsonProperty("team")]
        public BoxscoreTeam team { get; set; }

        [JsonProperty("teamStats")]
        public TeamStats teamStats { get; set; }

        [JsonProperty("players")]
        public Players players { get; set; }

        [JsonProperty("batters")]
        public IList<int> batters { get; set; }

        [JsonProperty("pitchers")]
        public IList<int> pitchers { get; set; }

        [JsonProperty("bench")]
        public IList<int> bench { get; set; }

        [JsonProperty("bullpen")]
        public IList<int> bullpen { get; set; }

        [JsonProperty("battingOrder")]
        public IList<int> battingOrder { get; set; }

        [JsonProperty("info")]
        public IList<Info> info { get; set; }

        [JsonProperty("note")]
        public IList<Note> note { get; set; }
    }

    public class FieldList
    {

        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class BoxscoreInfo
    {

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("fieldList")]
        public IList<FieldList> fieldList { get; set; }
    }

    public class BoxscoreHome
    {

        [JsonProperty("team")]
        public BoxscoreTeam team{ get; set; }

        [JsonProperty("teamStats")]
        public TeamStats teamStats { get; set; }

        [JsonProperty("players")]
        public  Players players { get; set; }

        [JsonProperty("batters")]
        public IList<int> batters { get; set; }

        [JsonProperty("pitchers")]
        public IList<int> pitchers { get; set; }

        [JsonProperty("bench")]
        public IList<int> bench { get; set; }

        [JsonProperty("bullpen")]
        public IList<int> bullpen { get; set; }

        [JsonProperty("battingOrder")]
        public IList<int> battingOrder { get; set; }

        [JsonProperty("info")]
        public IList<BoxscoreInfo> info { get; set; }

        [JsonProperty("note")]
        public IList<object> note { get; set; }
    }

    public class BoxscoreTeams
    {

        [JsonProperty("away")]
        public BoxscoreAway away { get; set; }

        [JsonProperty("home")]
        public BoxscoreHome home { get; set; }
    }

    public class Official
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class BoxscoreOfficial
    {

        [JsonProperty("official")]
        public Official official { get; set; }

        [JsonProperty("officialType")]
        public string officialType { get; set; }
    }

    public class GameInfo
    {

        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class MlbBoxscore
    {

        [JsonProperty("copyright")]
        public string copyright { get; set; }

        [JsonProperty("teams")]
        public BoxscoreTeams teams { get; set; }

        [JsonProperty("officials")]
        public IList<BoxscoreOfficial> officials { get; set; }

        [JsonProperty("info")]
        public IList<GameInfo> info { get; set; }

        [JsonProperty("pitchingNotes")]
        public IList<string> pitchingNotes { get; set; }
    }

}