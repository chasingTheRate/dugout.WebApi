using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
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

		public MlbController(IMlbService mlbService, IMlbApiService mlbApiService) {
			_mlbService = mlbService;
			_mlbApiService = mlbApiService;
		}

		private async Task<List<JbsBoxscore>> GetJbsBoxscores(IList<Game> games){
			var boxscores = new List<JbsBoxscore>();
			foreach(var game in games){
				var gameData = new MlbGameData();
				gameData.id = game.gamePk.ToString();
				gameData.status = game.status;
				gameData.gameDate = game.gameDate;
				gameData.boxscore = await _mlbApiService.GetBoxscore(game.gamePk.ToString());
				gameData.feedLive = await _mlbApiService.GetGameFeedLive(game.gamePk.ToString());
				gameData.linescore = await _mlbApiService.GetGameLinescore(game.gamePk.ToString());
				boxscores.Add(_mlbService.BuildBoxscore(gameData));
			}
			return boxscores;
		}

		[HttpGet]
		public IActionResult Index()
		{ 
			return Content("Welcome to the Dugout Web Api...");
		}

		[HttpGet]
		public Task<JbsBoxscores> boxscores(string date)
		{ 
			return _mlbService.GetBoxscoresByDate(date);
		}

		[HttpPost]
		public async Task<List<JbsBoxscore>> UpdateBoxscores(string date)
		{ 
			var schedule = await _mlbApiService.GetSchedule(date);
			var games = schedule.dates[0].games;
			var boxscores = await GetJbsBoxscores(games);
			_mlbService.CreateOrUpdateBoxscores(new JbsBoxscores{
				id = date,
				boxscores = boxscores,
			});
			return boxscores;
		}
	}
}