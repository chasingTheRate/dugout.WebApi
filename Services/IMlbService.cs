using System.Threading.Tasks;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public interface IMlbService
{
    Task<IList<Team>> GetTeams(int id);
};
}

