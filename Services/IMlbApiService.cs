using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbApiService
  {
    Task<MlbSchedule> GetSchedule(string date);
    Task<MlbBoxscore> GetBoxscore(string gameId);
    Task<MlbGameFeedLive> GetGameFeedLive(string gameId);
    Task<MlbGameLinescore> GetGameLinescore(string gameId);
    Task<MlbLeagueLeaders> GetLeagueLeaders(string statGroup, List<string> categories);
  };
}

