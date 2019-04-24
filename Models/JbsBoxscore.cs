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
  public class JbsBoxscore {
    public string homeLocationName { get; set; }
    public string awayLocationName { get; set; }
    public string homeTeamName { get; set; }
    public string awayTeamName { get; set; }
    public string homeShortName { get; set; }
    public string awayShortName { get; set; }
    public List<JbsBoxscoreBatter> homeBatters { get; set;}
    public List<JbsBoxscoreBatter> awayBatters { get; set;}
    public IList<Info> fieldingAndBattingInfo { get; set; }
    
    //  linescore
    //  batters
    //  gameInfo
    //  pitchers
    //  gameInfo
  }

  public class JbsBoxscoreBatter {
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
}