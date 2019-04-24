using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using dugout.WebApi.Models;
using dugout.WebApi.Extentions;
using MongoDB.Driver;

namespace dugout.WebApi.Services {
  public class MlbService : IMlbService
	{
    private readonly IMongoCollection<Team> _teams;
    private readonly IMongoCollection<MlbRosters> _rosters;
    private readonly IMongoCollection<Person> _players;
    private readonly IMongoCollection<ScheduleDate> _dates;

    public MlbService(IConfiguration config)
    {
        var client = new MongoClient(config.GetConnectionString("mongoDb"));
        var database = client.GetDatabase("mlb");
        _teams = database.GetCollection<Team>("Teams");
				_rosters = database.GetCollection<MlbRosters>("Roster");
				_players = database.GetCollection<Person>("Player");
				_dates = database.GetCollection<ScheduleDate>("Dates");
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

		public void CreateOrUpdatePlayers(IList<Person> players)
		{
			players.ToList().ForEach(player => {
				var filter = Builders<Person>.Filter.Eq(m => m.id, player.id);
				_players.ReplaceOneAsync(filter, player, new UpdateOptions {IsUpsert = true});
			});
		}

		public void CreateOrUpdateSchedule(ScheduleDate date)
		{
			var filter = Builders<ScheduleDate>.Filter.Eq(d => d.date, date.date);
			_dates.ReplaceOneAsync(filter, date, new UpdateOptions {IsUpsert = true});
		}

		private List<JbsBoxscoreBatter> BuildBatterList(IList<int> batterIds, List<BoxscorePlayer> boxscorePlayers, List<MlbGameFeedPlayer> gameFeedPlayers) {
			var batterList = new List<JbsBoxscoreBatter>();
			foreach(var batterId in batterIds) {
				var jbsBatter = new JbsBoxscoreBatter();
				var boxscorePlayer = boxscorePlayers.Find(p => p.person.id == batterId);
				jbsBatter.name = gameFeedPlayers.Find(p => p.id == batterId).boxscoreName;
				jbsBatter.position = boxscorePlayer.position.abbreviation;
				jbsBatter.atBats = boxscorePlayer.stats.batting.atBats.ToString();
				jbsBatter.runs = boxscorePlayer.stats.batting.runs.ToString();
				jbsBatter.hits = boxscorePlayer.stats.batting.hits.ToString();
				jbsBatter.rbi = boxscorePlayer.stats.batting.rbi.ToString();
				jbsBatter.baseOnBalls = boxscorePlayer.stats.batting.baseOnBalls.ToString();
				jbsBatter.strikeOuts = boxscorePlayer.stats.batting.strikeOuts.ToString();
				jbsBatter.avg = boxscorePlayer.seasonStats.batting.avg.ToString();
				batterList.Add(jbsBatter);
			}
			return batterList;
		}

		private List<FieldList> MergeFieldLists(IList<FieldList> awayFieldList, IList<FieldList> homeFieldList) {
			var fieldLists = new List<FieldList>();
			fieldLists.AddRange(awayFieldList);
			foreach(var field in homeFieldList) {
				try {
					fieldLists.Where(i => i.label == field.label).First().value.ToList().AddRange(field.value);
				}
				catch {
					fieldLists.Add(field);
				}
			}

			return fieldLists;
		}

		private List<Info> BuildFieldingAndBattingInfo(IList<Info> awayInfo, IList<Info> homeInfo){
			var fieldingAndBattingInfo = new List<Info>();
			fieldingAndBattingInfo.AddRange(awayInfo);
			foreach(var info in homeInfo){
				try {
					var tempInfo = fieldingAndBattingInfo.Where(i => i.title == info.title).ToList().First();
					tempInfo.fieldList.ToList().MergeFieldLists(info.fieldList.ToList());
				}
				catch {
					fieldingAndBattingInfo.Add(info);
				}
			}
			return fieldingAndBattingInfo;
		}

		public JbsBoxscore BuildBoxscore(MlbGameData gameData) {
			var boxscore = new JbsBoxscore();
			var awayTeamBox = gameData.boxscore.teams.away;
			var homeTeamBox = gameData.boxscore.teams.home;
			boxscore.awayLocationName = awayTeamBox.team.locationName;
			boxscore.homeLocationName = homeTeamBox.team.locationName;
			boxscore.awayTeamName = awayTeamBox.team.teamName;
			boxscore.homeTeamName = homeTeamBox.team.teamName;
			boxscore.homeShortName = awayTeamBox.team.shortName;
			boxscore.awayShortName = homeTeamBox.team.shortName;
			boxscore.homeBatters = BuildBatterList(homeTeamBox.batters, homeTeamBox.players.players, gameData.feedLive.gameData.players.players);
			boxscore.awayBatters = BuildBatterList(awayTeamBox.batters, awayTeamBox.players.players, gameData.feedLive.gameData.players.players);
			boxscore.fieldingAndBattingInfo = BuildFieldingAndBattingInfo(awayTeamBox.info, homeTeamBox.info);

			//	Build Team Info

			//	Build Pitchers

			//	Build Game Info

			return boxscore;
		}
    public async Task<IList<Team>> GetTeams()
    {
			return await _teams.Find(_ => true).ToListAsync();
    }

		public async Task<IList<MlbRosters>> GetRosters()
    {
			return await _rosters.Find(_ => true).ToListAsync();
    }

		public async Task<IList<Person>> GetPlayers()
    {
			return await _players.Find(_ => true).ToListAsync();
    }
	}
}
