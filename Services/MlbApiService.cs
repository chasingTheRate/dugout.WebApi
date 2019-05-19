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

    public async Task<MlbSchedule> GetSchedule(string date)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/schedule?sportId=1&date={date}";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbSchedule>(response);
    }

    public async Task<MlbBoxscore> GetBoxscore(string gameId)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/game/{gameId}/boxscore";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbBoxscore>(response);
    }

    public async Task<MlbGameFeedLive> GetGameFeedLive(string gameId)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1.1/game/{gameId}/feed/live";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbGameFeedLive>(response);
    }

    public async Task<MlbGameLinescore> GetGameLinescore(string gameId)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/game/{gameId}/linescore";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbGameLinescore>(response);
    }

    public async Task<MlbLeagueLeaders> GetLeagueLeaders()
    {
        var uri = $"https://statsapi.mlb.com/api/v1/stats/leaders?leaderCategories=wins,saves,earnedRunAverage,strikeouts,battingAverage,homeRuns,runsBattedIn,stolenBases&leaderGameTypes=R&season=2019&hydrate=person,team&limit=10";
        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbLeagueLeaders>(response);
    }

  }
}
