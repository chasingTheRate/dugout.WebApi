using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using dugout.WebApi.Services;
using dugout.WebApi.Models;
using dugout.WebApi.Mappings;


namespace dugout.WebApi.Controllers
{
	[Route("api/[controller]/{action}")]
	[ApiController]
	public class MlbController : ControllerBase
	{
		public IMlbService _mlbService;
		public IMlbApiService _mlbApiService;
		public IMapper _mapper;

		public MlbController(IMlbService mlbService, IMlbApiService mlbApiService, IMapper mapper) {
			_mlbService = mlbService;
			_mlbApiService = mlbApiService;
			_mapper = mapper;
		}

		private async Task<List<MlbRosters>> GetRosters(IList<Team> teams) {
			var roster = new List<MlbRosters>();
			foreach(var team in teams) {
				var teamRoster = await _mlbApiService.GetTeamRoster(team.id);
				roster.Add(teamRoster);
			}
			return roster;
		}

	private string BuildPlayerIdQueryString(IList<Roster> roster) {
		var playerQueryString = "";
		for(var i = 0; i<roster.Count; i++) {
			if (i != roster.Count)
			{
				playerQueryString += $"{roster[i].person.id}%2C";
			}
			else 
			{
				playerQueryString += $"{roster[i].person.id}";
			}
		}
		return playerQueryString;
	}
		private async Task<List<Person>> GetPlayers(IList<MlbRosters> rosters) {
			var players = new List<Person>();
			foreach(var teamRoster in rosters) {
				var playerIdsAsQueryString = BuildPlayerIdQueryString(teamRoster.roster);
				var teamPlayers = await _mlbApiService.GetPlayers(playerIdsAsQueryString);
				players.AddRange(teamPlayers);
			}
			return players;
		}

	
		[HttpPost]
		public async Task<IEnumerable<Team>> UpdateTeams()
		{ 
			var teams = await _mlbApiService.GetTeams(SportIds.Mlb);
			_mlbService.CreateOrUpdateTeams(teams);
			return teams;
		}

		[HttpPost]
		public async void UpdateTeamRosters()
		{ 
			var teams = await _mlbService.GetTeams();
			var rosters = await GetRosters(teams);
			_mlbService.CreateOrUpdateRosters(rosters);
		}

		[HttpPost]
		public async void UpdatePlayers()
		{ 
			var rosters = await _mlbService.GetRosters();
			var players = await GetPlayers(rosters);
			_mlbService.CreateOrUpdatePlayers(players);
		}

		[HttpPost]
		public async void UpdateSchedule()
		{ 
			DateTime today = DateTime.Today;
			Console.WriteLine(today.ToString("d"));
			var mlbSchedule = await _mlbApiService.GetSchedule(today.ToString("d"));
			_mlbService.CreateOrUpdateSchedule(mlbSchedule.dates[0]);
		}

		[HttpPost]
		public async void UpdateBoxscores(string date)
		{ 
			var gameData = new MlbGameData();
			gameData.boxscore = await _mlbApiService.GetBoxscore("566775");
			gameData.feedLive = await _mlbApiService.GetGameFeedLive("566775");
			gameData.linescore = await _mlbApiService.GetGameLinescore("566775");

			var boxscore = _mlbService.BuildBoxscore(gameData);
			//	Build LBS Boxscore

			// 	Save to Mongo?

			//	Push to Firebase
		}

		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}