
namespace dugout.WebApi.Models {

  public class MlbGameData {
    public MlbBoxscore boxscore { get; set;}
    public MlbGameLinescore linescore { get; set;}
    public MlbGameFeedLive feedLive { get; set; }

  }
}