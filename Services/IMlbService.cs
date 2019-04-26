using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbService
  {
    void CreateOrUpdateBoxscores(JbsBoxscores boxscores);
    Task<JbsBoxscores> GetBoxscoresByDate(string date);

    JbsBoxscore BuildBoxscore(MlbGameData gameData);
  };
}

