
using AutoMapper;
using dugout.WebApi.Models;

namespace dugout.WebApi.Mappings
{
  public class MappingProfile : Profile {
    public MappingProfile() {
        // Add as many of these lines as you need to map your objects
        CreateMap<MlbGameData, JbsBoxscore>();
        CreateMap<JbsBoxscore, MlbGameData>();
    }
  }
}
