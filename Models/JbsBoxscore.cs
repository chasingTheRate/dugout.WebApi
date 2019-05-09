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

  public class JbsBoxscores {
    [BsonId]
     public string id { get; set; }
     public List<JbsBoxscore> boxscores;
  }
  public class JbsBoxscore {
    [JsonProperty("id")]
     public string id { get; set; }
    [JsonProperty("status")]
     public ScheduleStatus status { get; set; }
     [JsonProperty("gameDate")]
     public DateTime gameDate { get; set; }


     [JsonProperty("homeLocationName")]
     public string homeLocationName { get; set; }
     [JsonProperty("awayLocationName")]
    public string awayLocationName { get; set; }
     [JsonProperty("homeTeamName")]
    public string homeTeamName { get; set; }
     [JsonProperty("awayTeamName")]
    public string awayTeamName { get; set; }
     [JsonProperty("homeShortName")]
    public string homeShortName { get; set; }
     [JsonProperty("awayShortName")]
    public string awayShortName { get; set; }
     [JsonProperty("linescore")]
    public MlbGameLinescore linescore { get; set;}
     [JsonProperty("homeBatters")]
    public List<JbsBoxscoreBatter> homeBatters { get; set;}
     [JsonProperty("awayBatters")]
    public List<JbsBoxscoreBatter> awayBatters { get; set;}
     [JsonProperty("homePitchers")]
    public List<JbsBoxscorePitcher> homePitchers { get; set;}
     [JsonProperty("awayPitchers")]
    public List<JbsBoxscorePitcher> awayPitchers { get; set;}
     [JsonProperty("fieldingAndBattingInfo")]
    public List<Info> fieldingAndBattingInfo { get; set; }
     [JsonProperty("pitchingAndGameInfo")]
    public List<Note> pitchingAndGameInfo { get; set; }
  }

  public class JbsBoxscoreBatter {
    public string id { get; set; }
    public string name { get; set; }
    public string position { get; set; }
    public string atBats { get; set; }
    public string runs { get; set; }
    public string hits { get; set; }
    public string rbi { get; set; }
    public string baseOnBalls { get; set; }
    public string strikeOuts { get; set; }
    public string avg { get; set; }
  }

  public class JbsBoxscorePitcher {
    public string id { get; set; }
    public string name { get; set; }
    public string position { get; set; }
    public string inningsPitched { get; set; }
    public string hits { get; set; }
    public string earnedRuns { get; set; }
    public string baseOnBalls { get; set; }
    public string strikeOuts { get; set; }
    public string numberOfPitches { get; set; }
    public string era { get; set; }
  }
}