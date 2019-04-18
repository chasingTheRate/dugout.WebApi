using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using dugout.WebApi.Models;
using System.Linq;
using MongoDB.Driver;

namespace dugout.WebApi.Services {
  public class MlbApiService : IMlbApiService
{
    private readonly HttpClient _httpClient;
    public MlbApiService(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
    }

    public async Task<IList<Team>> GetTeams(int sportsId)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/teams?sportId={sportsId}";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbTeams>(response).teams;
    }
    public async Task<MlbRosters> GetTeamRoster(int teamId)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/teams/{teamId}/roster";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbRosters>(response);
    }
}
}
