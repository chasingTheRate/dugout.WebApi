using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models {
 public class ScheduleStatus
  {
    public ScheduleStatus()
    {
      Id = ObjectId.GenerateNewId();
    }
    public ObjectId Id { get; set; }

    [BsonElement("abstractGameState")]
    public string abstractGameState { get; set; }

    [BsonElement("codedGameState")]
    public string codedGameState { get; set; }

    [BsonElement("detailedState")]
    public string detailedState { get; set; }

    [BsonElement("statusCode")]
    public string statusCode { get; set; }

    [BsonElement("abstractGameCode")]
    public string abstractGameCode { get; set; }
  }

	public class LeagueRecord
	{
			public LeagueRecord()
			{
				Id = ObjectId.GenerateNewId();
			}
			public ObjectId Id { get; set; }

			[BsonElement("wins")]
			public int wins { get; set; }

			[BsonElement("losses")]
			public int losses { get; set; }

			[BsonElement("pct")]
			public string pct { get; set; }
	}

	public class ScheduleTeam
	{

			[BsonId]
			public int id { get; set; }

			[BsonElement("name")]
			public string name { get; set; }

			[BsonElement("link")]
			public string link { get; set; }
	}

	public class Away
	{
			public Away()
			{
				Id = ObjectId.GenerateNewId();
			}
			public ObjectId Id { get; set; }

			[BsonElement("leagueRecord")]
			public LeagueRecord leagueRecord { get; set; }

			[BsonElement("score")]
			public int score { get; set; }

			[BsonElement("team")]
			public ScheduleTeam team { get; set; }

			[BsonElement("isWinner")]
			public bool isWinner { get; set; }

			[BsonElement("splitSquad")]
			public bool splitSquad { get; set; }

			[BsonElement("seriesNumber")]
			public int seriesNumber { get; set; }
	}

	public class Home
	{
			public Home()
			{
				Id = ObjectId.GenerateNewId();
			}
			public ObjectId Id { get; set; }

			[BsonElement("leagueRecord")]
			public LeagueRecord leagueRecord { get; set; }

			[BsonElement("score")]
			public int score { get; set; }

			[BsonElement("team")]
			public ScheduleTeam team { get; set; }

			[BsonElement("isWinner")]
			public bool isWinner { get; set; }

			[BsonElement("splitSquad")]
			public bool splitSquad { get; set; }

			[BsonElement("seriesNumber")]
			public int seriesNumber { get; set; }
	}

	public class Teams
	{
			public Teams()
			{
				Id = ObjectId.GenerateNewId();
			}
			public ObjectId Id { get; set; }

			[BsonElement("away")]
			public Away away { get; set; }

			[BsonElement("home")]
			public Home home { get; set; }
	}

	public class ScheduleVenue
	{

			[BsonId]
			public int id { get; set; }

			[BsonElement("name")]
			public string name { get; set; }

			[BsonElement("link")]
			public string link { get; set; }
	}

	public class Content
	{
			public Content()
			{
				Id = ObjectId.GenerateNewId();
			}
			public ObjectId Id { get; set; }

			[BsonElement("link")]
			public string link { get; set; }
	}

	public class Game
	{
		public Game()
		{
			Id = ObjectId.GenerateNewId();
		}
		public ObjectId Id { get; set; }

		[BsonElement("gamePk")]
		public int gamePk { get; set; }

		[BsonElement("link")]
		public string link { get; set; }

		[BsonElement("gameType")]
		public string gameType { get; set; }

		[BsonElement("season")]
		public string season { get; set; }

		[BsonElement("gameDate")]
		public DateTime gameDate { get; set; }

		[BsonElement("status")]
		public ScheduleStatus status { get; set; }

		[BsonElement("teams")]
		public Teams teams { get; set; }

		[BsonElement("venue")]
		public ScheduleVenue venue { get; set; }

		[BsonElement("content")]
		public Content content { get; set; }

		[BsonElement("isTie")]
		public bool isTie { get; set; }

		[BsonElement("gameNumber")]
		public int gameNumber { get; set; }

		[BsonElement("publicFacing")]
		public bool publicFacing { get; set; }

		[BsonElement("doubleHeader")]
		public string doubleHeader { get; set; }

		[BsonElement("gamedayType")]
		public string gamedayType { get; set; }

		[BsonElement("tiebreaker")]
		public string tiebreaker { get; set; }

		[BsonElement("calendarEventID")]
		public string calendarEventID { get; set; }

		[BsonElement("seasonDisplay")]
		public string seasonDisplay { get; set; }

		[BsonElement("dayNight")]
		public string dayNight { get; set; }

		[BsonElement("scheduledInnings")]
		public int scheduledInnings { get; set; }

		[BsonElement("gamesInSeries")]
		public int gamesInSeries { get; set; }

		[BsonElement("seriesGameNumber")]
		public int seriesGameNumber { get; set; }

		[BsonElement("seriesDescription")]
		public string seriesDescription { get; set; }

		[BsonElement("recordSource")]
		public string recordSource { get; set; }

		[BsonElement("ifNecessary")]
		public string ifNecessary { get; set; }

		[BsonElement("ifNecessaryDescription")]
		public string ifNecessaryDescription { get; set; }
	}

	public class ScheduleDate
	{
		[BsonId]
		public string date { get; set; }

		[BsonElement("totalItems")]
		public int totalItems { get; set; }

		[BsonElement("totalEvents")]
		public int totalEvents { get; set; }

		[BsonElement("totalGames")]
		public int totalGames { get; set; }

		[BsonElement("totalGamesInProgress")]
		public int totalGamesInProgress { get; set; }

		[BsonElement("games")]
		public IList<Game> games { get; set; }

		[BsonElement("events")]
		public IList<object> events { get; set; }
	}

	public class MlbSchedule
	{
		[BsonElement("copyright")]
		public string copyright { get; set; }

		[BsonElement("totalItems")]
		public int totalItems { get; set; }

		[BsonElement("totalEvents")]
		public int totalEvents { get; set; }

		[BsonElement("totalGames")]
		public int totalGames { get; set; }

		[BsonElement("totalGamesInProgress")]
		public int totalGamesInProgress { get; set; }

		[BsonElement("dates")]
		public IList<ScheduleDate> dates { get; set; }
	}
}