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
   public class MetaData
    {

        [JsonProperty("wait")]
        public int wait { get; set; }

        [JsonProperty("timeStamp")]
        public string timeStamp { get; set; }

        [JsonProperty("gameEvents")]
        public IList<object> gameEvents { get; set; }

        [JsonProperty("logicalEvents")]
        public IList<object> logicalEvents { get; set; }
    }

    public class MlbGameFeedLiveGame
    {

        [JsonProperty("pk")]
        public int pk { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("doubleHeader")]
        public string doubleHeader { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("gamedayType")]
        public string gamedayType { get; set; }

        [JsonProperty("tiebreaker")]
        public string tiebreaker { get; set; }

        [JsonProperty("gameNumber")]
        public int gameNumber { get; set; }

        [JsonProperty("calendarEventID")]
        public string calendarEventID { get; set; }

        [JsonProperty("season")]
        public string season { get; set; }

        [JsonProperty("seasonDisplay")]
        public string seasonDisplay { get; set; }
    }

    public class Datetime
    {

        [JsonProperty("dateTime")]
        public DateTime dateTime { get; set; }

        [JsonProperty("originalDate")]
        public string originalDate { get; set; }

        [JsonProperty("dayNight")]
        public string dayNight { get; set; }

        [JsonProperty("time")]
        public string time { get; set; }

        [JsonProperty("ampm")]
        public string ampm { get; set; }
    }

    public class MlbGameFeedLiveStatus
    {

        [JsonProperty("abstractGameState")]
        public string abstractGameState { get; set; }

        [JsonProperty("codedGameState")]
        public string codedGameState { get; set; }

        [JsonProperty("detailedState")]
        public string detailedState { get; set; }

        [JsonProperty("statusCode")]
        public string statusCode { get; set; }

        [JsonProperty("abstractGameCode")]
        public string abstractGameCode { get; set; }
    }

    public class MlbGameFeedLiveVenue
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameFeedLiveLeague
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameFeedLiveDivision
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameFeedLiveSport
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class MlbGameFeedLeagueRecord
    {

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("pct")]
        public string pct { get; set; }
    }

    public class MlbGameFeedRecords
    {
    }

    public class MlbGameFeedRecord
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
        public MlbGameFeedLeagueRecord leagueRecord { get; set; }

        [JsonProperty("records")]
        public MlbGameFeedRecords records { get; set; }

        [JsonProperty("divisionLeader")]
        public bool divisionLeader { get; set; }

        [JsonProperty("wins")]
        public int wins { get; set; }

        [JsonProperty("losses")]
        public int losses { get; set; }

        [JsonProperty("winningPercentage")]
        public string winningPercentage { get; set; }
    }

    public class MlbGameFeedSpringLeague
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

    public class MlbGameFeedAway
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
        public MlbGameFeedLiveVenue venue { get; set; }

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
        public MlbGameFeedLiveLeague league { get; set; }

        [JsonProperty("division")]
        public MlbGameFeedLiveDivision division { get; set; }

        [JsonProperty("sport")]
        public MlbGameFeedLiveSport sport { get; set; }

        [JsonProperty("shortName")]
        public string shortName { get; set; }

        [JsonProperty("record")]
        public MlbGameFeedRecord record { get; set; }

        [JsonProperty("springLeague")]
        public MlbGameFeedSpringLeague springLeague { get; set; }

        [JsonProperty("allStarStatus")]
        public string allStarStatus { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }
    }

    public class MlbGameFeedHome
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
        public  MlbGameFeedLiveVenue venue { get; set; }

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
        public  MlbGameFeedLiveLeague league { get; set; }

        [JsonProperty("division")]
        public  MlbGameFeedLiveDivision division { get; set; }

        [JsonProperty("sport")]
        public  MlbGameFeedLiveSport sport { get; set; }

        [JsonProperty("shortName")]
        public string shortName { get; set; }

        [JsonProperty("record")]
        public  MlbGameFeedRecord record { get; set; }

        [JsonProperty("springLeague")]
        public  MlbGameFeedSpringLeague springLeague { get; set; }

        [JsonProperty("allStarStatus")]
        public string allStarStatus { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }
    }

    public class MlbGameFeedTeams
    {

        [JsonProperty("away")]
        public MlbGameFeedAway away { get; set; }

        [JsonProperty("home")]
        public MlbGameFeedHome home { get; set; }
    }

    public class MlbGameFeedPrimaryPosition
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

    public class MlbGameFeedBatSide
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    public class MlbGameFeedPitchHand
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }

    public class MlbGameFeedPlayer {

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

        [JsonProperty("birthStateProvince")]
        public string birthStateProvince { get; set; }

        [JsonProperty("birthCountry")]
        public string birthCountry { get; set; }

        [JsonProperty("height")]
        public string height { get; set; }

        [JsonProperty("weight")]
        public int weight { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }

        [JsonProperty("primaryPosition")]
        public MlbGameFeedPrimaryPosition primaryPosition { get; set; }

        [JsonProperty("useName")]
        public string useName { get; set; }

        [JsonProperty("middleName")]
        public string middleName { get; set; }

        [JsonProperty("boxscoreName")]
        public string boxscoreName { get; set; }

        [JsonProperty("nickName")]
        public string nickName { get; set; }

        [JsonProperty("draftYear")]
        public int draftYear { get; set; }

        [JsonProperty("mlbDebutDate")]
        public string mlbDebutDate { get; set; }

        [JsonProperty("batSide")]
        public MlbGameFeedBatSide batSide { get; set; }

        [JsonProperty("pitchHand")]
        public MlbGameFeedPitchHand pitchHand { get; set; }

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
    }
    public class MlbGameFeedPlayers
    {
      public MlbGameFeedPlayers() {
        players = new List<MlbGameFeedPlayer>();
      }
      [JsonExtensionData]
      private IDictionary<string, JToken> _data { get; set; }
      public List<MlbGameFeedPlayer> players { get; set; }

      [OnDeserialized]
      private void OnDeserialized(StreamingContext context)
      {
        foreach(KeyValuePair<string, JToken> entry in _data)
        {
          var player = entry.Value.ToObject<MlbGameFeedPlayer>();
          players.Add(player);
        } 
      }
    }

    public class Weather
    {
    }

    public class Review
    {

        [JsonProperty("away")]
        public  MlbGameFeedAway away { get; set; }

        [JsonProperty("home")]
        public MlbGameFeedHome home { get; set; }
    }

    public class Flags
    {
    }

    public class ProbablePitchers
    {

        [JsonProperty("away")]
        public  MlbGameFeedAway away { get; set; }

        [JsonProperty("home")]
        public  MlbGameFeedHome home { get; set; }
    }

    public class GameData
    {

        [JsonProperty("game")]
        public MlbGameFeedLiveGame game { get; set; }

        [JsonProperty("datetime")]
        public Datetime datetime { get; set; }

        [JsonProperty("status")]
        public MlbGameFeedLiveStatus status { get; set; }

        [JsonProperty("teams")]
        public MlbGameFeedTeams teams { get; set; }

        [JsonProperty("players")]
        public MlbGameFeedPlayers players { get; set; }

        [JsonProperty("venue")]
        public  MlbGameFeedLiveVenue venue { get; set; }

        [JsonProperty("weather")]
        public Weather weather { get; set; }

        [JsonProperty("review")]
        public Review review { get; set; }

        [JsonProperty("flags")]
        public Flags flags { get; set; }

        [JsonProperty("alerts")]
        public IList<object> alerts { get; set; }

        [JsonProperty("probablePitchers")]
        public ProbablePitchers probablePitchers { get; set; }
    }

    public class Plays
    {

        [JsonProperty("allPlays")]
        public IList<object> allPlays { get; set; }

        [JsonProperty("scoringPlays")]
        public IList<object> scoringPlays { get; set; }

        [JsonProperty("playsByInning")]
        public IList<object> playsByInning { get; set; }
    }

    public class Defense
    {
    }

    public class Offense
    {
    }

    public class Linescore
    {

        [JsonProperty("innings")]
        public IList<object> innings { get; set; }

        [JsonProperty("teams")]
        public  MlbGameFeedTeams teams { get; set; }

        [JsonProperty("defense")]
        public Defense defense { get; set; }

        [JsonProperty("offense")]
        public Offense offense { get; set; }
    }

    public class Boxscore
    {

        [JsonProperty("teams")]
        public MlbGameFeedTeams teams { get; set; }

        [JsonProperty("officials")]
        public IList<object> officials { get; set; }

        [JsonProperty("info")]
        public IList<object> info { get; set; }

        [JsonProperty("pitchingNotes")]
        public IList<object> pitchingNotes { get; set; }
    }

    public class Decisions
    {
    }

    public class HitDistance
    {
    }

    public class HitSpeed
    {
    }

    public class PitchSpeed
    {
    }

    public class Leaders
    {

        [JsonProperty("hitDistance")]
        public HitDistance hitDistance { get; set; }

        [JsonProperty("hitSpeed")]
        public HitSpeed hitSpeed { get; set; }

        [JsonProperty("pitchSpeed")]
        public PitchSpeed pitchSpeed { get; set; }
    }

    public class LiveData
    {

        [JsonProperty("plays")]
        public Plays plays { get; set; }

        [JsonProperty("linescore")]
        public Linescore linescore { get; set; }

        [JsonProperty("boxscore")]
        public Boxscore boxscore { get; set; }

        [JsonProperty("decisions")]
        public Decisions decisions { get; set; }

        [JsonProperty("leaders")]
        public Leaders leaders { get; set; }
    }

    public class MlbGameFeedLive
    {

        [JsonProperty("gamePk")]
        public int gamePk { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }

        [JsonProperty("metaData")]
        public MetaData metaData { get; set; }

        [JsonProperty("gameData")]
        public GameData gameData { get; set; }

        [JsonProperty("liveData")]
        public LiveData liveData { get; set; }
    }
}