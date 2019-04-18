using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbService
  {
    void CreateOrUpdateTeams(IList<Team> teams);
    void CreateOrUpdateRosters(IList<MlbRosters> rosters);
    Task<IList<Team>> GetTeams();
    Task<IList<MlbRosters>> GetRosters();

  };
}

