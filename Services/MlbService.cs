using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using dugout.WebApi.Models;
using dugout.WebApi.Extentions;
using MongoDB.Driver;

namespace dugout.WebApi.Services {
  public class MlbService : IMlbService
	{
    private readonly IMongoCollection<JbsBoxscores> _boxscores;
    private readonly IMongoCollection<JbsLeagueLeaders> _leagueLeaders;

    public MlbService(IConfiguration config)
    {
        var client = new MongoClient(config.GetConnectionString("MongoDb"));
        var database = client.GetDatabase("mlb");
				_boxscores = database.GetCollection<JbsBoxscores>("Boxscores");
				_leagueLeaders = database.GetCollection<JbsLeagueLeaders>("LeagueLeaders");
    }

		public async Task<JbsBoxscores> GetBoxscoresByDate(string date) {
			var boxscores = await _boxscores.FindAsync(x => x.id == date);
			return boxscores.ToList().FirstOrDefault();
		}

		public async Task<IList<JbsLeagueLeaders>> GetLeagueLeaders() {
			var leagueLeadersList = await _leagueLeaders.FindAsync(_ => true);
			return leagueLeadersList.ToList();
		}
		public void CreateOrUpdateBoxscores(JbsBoxscores boxscores)
    {
			var filter = Builders<JbsBoxscores>.Filter.Eq(d => d.id, boxscores.id);
			_boxscores.ReplaceOneAsync(filter, boxscores, new UpdateOptions {IsUpsert = true});
    }

		public void CreateOrUpdateLeagueLeaders(IList<JbsLeagueLeaders> leagueLeadersList)
    {
			foreach (var leagueLeaders in leagueLeadersList) {
				var filter = Builders<JbsLeagueLeaders>.Filter.Eq(d => d.leaderCategory, leagueLeaders.leaderCategory);
				_leagueLeaders.ReplaceOneAsync(filter, leagueLeaders, new UpdateOptions {IsUpsert = true});
			}
    }
		private List<JbsBoxscoreBatter> BuildBatterList(IList<int> batterIds, List<BoxscorePlayer> boxscorePlayers, List<MlbGameFeedPlayer> gameFeedPlayers) {
			var batterList = new List<JbsBoxscoreBatter>();
			foreach(var batterId in batterIds) {
				var jbsBatter = new JbsBoxscoreBatter();
				var boxscorePlayer = boxscorePlayers.Find(p => p.person.id == batterId);
				try {
					jbsBatter.name = gameFeedPlayers.Find(p => p.id == batterId).boxscoreName;
				} catch {
					System.Console.WriteLine("Error: BuildBatterList");
					continue;
				}
				jbsBatter.id = batterId.ToString();
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
		private List<JbsBoxscorePitcher> BuildPitcherList(IList<int> pitcherIds, List<BoxscorePlayer> boxscorePlayers, List<MlbGameFeedPlayer> gameFeedPlayers) {
			var pitcherList = new List<JbsBoxscorePitcher>();
			foreach(var pitcherId in pitcherIds) {
				var jbsPitcher = new JbsBoxscorePitcher();
				var boxscorePlayer = boxscorePlayers.Find(p => p.person.id == pitcherId);
				try {
					jbsPitcher.name = gameFeedPlayers.Find(p => p.id == pitcherId).boxscoreName;
				} catch {
					System.Console.WriteLine("Error: BuildPitcherList");
					continue;
				}
				jbsPitcher.id = pitcherId.ToString();
				jbsPitcher.position = boxscorePlayer.position.abbreviation;
				jbsPitcher.inningsPitched = boxscorePlayer.stats.pitching.inningsPitched;
				jbsPitcher.hits = boxscorePlayer.stats.pitching.hits.ToString();
				jbsPitcher.earnedRuns = boxscorePlayer.stats.pitching.earnedRuns.ToString();
				jbsPitcher.baseOnBalls = boxscorePlayer.stats.pitching.baseOnBalls.ToString();
				jbsPitcher.strikeOuts = boxscorePlayer.stats.pitching.strikeOuts.ToString();
				jbsPitcher.numberOfPitches = boxscorePlayer.stats.pitching.numberOfPitches.ToString();
				jbsPitcher.era = boxscorePlayer.seasonStats.pitching.era.ToString();
				pitcherList.Add(jbsPitcher);
			}
			return pitcherList;
		}
		private List<Info> BuildFieldingAndBattingInfo(IList<Info> awayInfo, IList<Info> homeInfo){
			var fieldingAndBattingInfo = new List<Info>();
			fieldingAndBattingInfo.AddRange(awayInfo);
			foreach(var info in homeInfo){
				try {
					var tempInfo = fieldingAndBattingInfo.Where(i => i.title == info.title).ToList().First();
					tempInfo.fieldList = tempInfo.fieldList.ToList().MergeFieldLists(info.fieldList.ToList());
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

			boxscore.status = gameData.status;
			boxscore.gameDate = gameData.gameDate;
			boxscore.id = gameData.id;
			boxscore.awayLocationName = awayTeamBox.team.locationName;
			boxscore.homeLocationName = homeTeamBox.team.locationName;
			boxscore.awayTeamName = awayTeamBox.team.teamName;
			boxscore.homeTeamName = homeTeamBox.team.teamName;
			boxscore.awayShortName = awayTeamBox.team.shortName;
			boxscore.homeShortName = homeTeamBox.team.shortName;
			boxscore.fieldingAndBattingInfo = BuildFieldingAndBattingInfo(awayTeamBox.info, homeTeamBox.info);
			boxscore.pitchingAndGameInfo = gameData.boxscore.info.ToList();
			boxscore.linescore = gameData.linescore;

			if(gameData.feedLive != null) {
				boxscore.homeBatters = BuildBatterList(homeTeamBox.batters, homeTeamBox.players.players, gameData.feedLive.gameData.players.players);
				boxscore.awayBatters = BuildBatterList(awayTeamBox.batters, awayTeamBox.players.players, gameData.feedLive.gameData.players.players);
				boxscore.homePitchers = BuildPitcherList(homeTeamBox.pitchers, homeTeamBox.players.players, gameData.feedLive.gameData.players.players);
				boxscore.awayPitchers = BuildPitcherList(awayTeamBox.pitchers, awayTeamBox.players.players, gameData.feedLive.gameData.players.players);
			}
			
			return boxscore;
		}
		public List<JbsLeagueLeaders> ConvertLeagueLeaders(IList<LeagueLeader> leagueLeaders) {
			var jbsLeagueLeadersList = new List<JbsLeagueLeaders>();
			foreach(var leagueLeader in leagueLeaders) {
				var jsbLeagueLeaders = new JbsLeagueLeaders();
				jsbLeagueLeaders.leagueleaders = new List<JbsLeagueLeader>();

				jsbLeagueLeaders.id = Guid.NewGuid().ToString();
				jsbLeagueLeaders.leaderCategory = leagueLeader.leaderCategory;
				jsbLeagueLeaders.statGroup = leagueLeader.statGroup;
				foreach (var leader in leagueLeader.leaders)
				{
					var jsbLeader = new JbsLeagueLeader();
					jsbLeader.id = leader.person.id.ToString();
					jsbLeader.lastFirstName = leader.person.lastFirstName;
					jsbLeader.rank = leader.rank;
					jsbLeader.teamAbbreviation = leader.team.abbreviation;
					jsbLeader.value = leader.value;
					jsbLeagueLeaders.leagueleaders.Add(jsbLeader);
				}
				jbsLeagueLeadersList.Add(jsbLeagueLeaders);
			}
			return jbsLeagueLeadersList;
		}
	}
}
