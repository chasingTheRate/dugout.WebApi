using Newtonsoft.Json;
using System.Collections.Generic;

namespace dugout.WebApi.Models {
  public class JbsLeagueLeaders {
    public string id { get; set; }
    public string leaderCategory { get; set; }
    public string statGroup { get; set; }
    public List<JbsLeagueLeader> leagueleaders;
  }

  public class JbsLeagueLeader {
    public string id {  get; set; }
    public int rank { get; set;  }
    public string value { get; set; }
    public string teamAbbreviation { get; set; }
    public string lastFirstName { get; set; }
  }
}
