using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using dugout.WebApi.Models;
using System.Linq;
using MongoDB.Driver;

namespace dugout.WebApi.Services {
  public class MlbService : IMlbService
	{
    private readonly IMongoCollection<Team> _teams;
    private readonly IMongoCollection<MlbRosters> _rosters;

    public MlbService(IConfiguration config)
    {
        var client = new MongoClient(config.GetConnectionString("mongoDb"));
        var database = client.GetDatabase("mlb");
        _teams = database.GetCollection<Team>("Teams");
				_rosters = database.GetCollection<MlbRosters>("Roster");
    }

    public void CreateOrUpdateTeams(IList<Team> teams)
    {
			teams.ToList().ForEach(team => {
				var filter = Builders<Team>.Filter.Eq(t => t.id, team.id);
				_teams.ReplaceOneAsync(filter, team, new UpdateOptions {IsUpsert = true});
			});
    }

    public void CreateOrUpdateRosters(IList<MlbRosters> rosters)
		{
			rosters.ToList().ForEach(roster => {
				var filter = Builders<MlbRosters>.Filter.Eq(m => m.teamId, roster.teamId);
				_rosters.ReplaceOneAsync(filter, roster, new UpdateOptions {IsUpsert = true});
			});
		}

    public async Task<IList<Team>> GetTeams()
    {
			return await _teams.Find(_ => true).ToListAsync();
    }

		public async Task<IList<MlbRosters>> GetRosters()
    {
			return await _rosters.Find(_ => true).ToListAsync();
    }
	}
}
