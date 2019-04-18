using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dugout.WebApi.Services;
using dugout.WebApi.Models;


namespace dugout.WebApi.Controllers
{
	[Route("api/[controller]/{action}")]
	[ApiController]
	public class MlbController : ControllerBase
	{
		public IMlbService _mlbService;
		public IMlbApiService _mlbApiService;

		private async Task<List<MlbRosters>> GetRosters(IList<Team> teams) {
			var roster = new List<MlbRosters>();
			foreach(var team in teams) {
				var teamRoster = await _mlbApiService.GetTeamRoster(team.id);
				roster.Add(teamRoster);
			}
			return roster;
		}

		public MlbController(IMlbService mlbService, IMlbApiService mlbApiService) {
			_mlbService = mlbService;
			_mlbApiService = mlbApiService;
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
			var test = await _mlbService.GetRosters();
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