using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbApiService
  {
    Task<IList<Team>> GetTeams(int sportId);
    Task<MlbRosters> GetTeamRoster(int teamId);
    Task<IList<Person>> GetPlayers(string queryParam);
    Task<MlbSchedule> GetSchedule(string date);
    Task<MlbBoxscore> GetBoxscore(string gameId);
    Task<MlbGameFeedLive> GetGameFeedLive(string gameId);
    Task<MlbGameLinescore> GetGameLinescore(string gameId);



  };
}

