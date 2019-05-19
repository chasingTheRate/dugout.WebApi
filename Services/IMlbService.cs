using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbService
  {
    void CreateOrUpdateBoxscores(JbsBoxscores boxscores);
    void CreateOrUpdateLeagueLeaders(IList<JbsLeagueLeaders> leagueLeadersList);

    Task<JbsBoxscores> GetBoxscoresByDate(string date);
    Task<IList<JbsLeagueLeaders>> GetLeagueLeaders();
    JbsBoxscore BuildBoxscore(MlbGameData gameData);
    List<JbsLeagueLeaders> ConvertLeagueLeaders(IList<LeagueLeader> leagueLeaders);
  };
}

