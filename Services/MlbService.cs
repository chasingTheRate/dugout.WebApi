using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Services {
  public class MlbService : IMlbService
{
    private readonly HttpClient _httpClient;
    private readonly string _remoteServiceBaseUrl;

    public MlbService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IList<Team>> GetTeams(int id)
    {
        var uri = $"http://statsapi.mlb.com:80/api/v1/teams?sportId={id}";

        var response = await _httpClient.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<MlbTeams>(response).teams;
    }
}
}
