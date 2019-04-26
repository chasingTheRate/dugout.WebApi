using System;

namespace dugout.WebApi.Models {

  public class MlbGameData {
    public string id { get; set;}
    public DateTime gameDate {get; set;}
    public ScheduleStatus status { get; set;}
    public MlbBoxscore boxscore { get; set;}
    public MlbGameLinescore linescore { get; set;}
    public MlbGameFeedLive feedLive { get; set; }

  }
}