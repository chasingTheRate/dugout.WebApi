using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbApiService
  {
    Task<IList<Team>> GetTeams(int sportId);
    Task<MlbRosters> GetTeamRoster(int teamId);
  };
}

