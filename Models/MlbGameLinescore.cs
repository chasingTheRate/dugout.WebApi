using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models {
  public class MlbGameLinescoreHome
    {

        [JsonProperty("runs")]
        public int runs { get; set; }

        [JsonProperty("hits")]
        public int hits { get; set; }

        [JsonProperty("errors")]
        public int errors { get; set; }

        [JsonProperty("leftOnBase")]
        public int leftOnBase { get; set; }
    }

    public class MlbGameLinescoreAway
    {

        [JsonProperty("runs")]
        public int runs { get; set; }

        [JsonProperty("hits")]
        public int hits { get; set; }

        [JsonProperty("errors")]
        public int errors { get; set; }

        [JsonProperty("leftOnBase")]
        public int leftOnBase { get; set; }
    }

    public class Innings
    {

        [JsonProperty("num")]
        public int num { get; set; }

        [JsonProperty("ordinalNum")]
        public string ordinalNum { get; set; }

        [JsonProperty("home")]
        public MlbGameLinescoreHome home { get; set; }

        [JsonProperty("away")]
        public MlbGameLinescoreAway away { get; set; }
    }

    public class MlbGameLinescoreTeams
    {

        [JsonProperty("home")]
        public  MlbGameLinescoreHome home { get; set; }

        [JsonProperty("away")]
        public MlbGameLinescoreAway away { get; set; }
    }

    public class Pitcher
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Catcher
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class First
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Second
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Third
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Shortstop
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Left
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Center
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class Right
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameLinescoreTeam
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameLinescoreDefense
    {

        [JsonProperty("pitcher")]
        public Pitcher pitcher { get; set; }

        [JsonProperty("catcher")]
        public Catcher catcher { get; set; }

        [JsonProperty("first")]
        public First first { get; set; }

        [JsonProperty("second")]
        public Second second { get; set; }

        [JsonProperty("third")]
        public Third third { get; set; }

        [JsonProperty("shortstop")]
        public Shortstop shortstop { get; set; }

        [JsonProperty("left")]
        public Left left { get; set; }

        [JsonProperty("center")]
        public Center center { get; set; }

        [JsonProperty("right")]
        public Right right { get; set; }

        [JsonProperty("team")]
        public MlbGameLinescoreTeam team { get; set; }
    }

    public class Batter
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class OnDeck
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class InHole
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fullName")]
        public string fullName { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }

    public class MlbGameLinescoreOffense
    {

        [JsonProperty("batter")]
        public Batter batter { get; set; }

        [JsonProperty("onDeck")]
        public OnDeck onDeck { get; set; }

        [JsonProperty("inHole")]
        public InHole inHole { get; set; }

        [JsonProperty("pitcher")]
        public Pitcher pitcher { get; set; }

        [JsonProperty("team")]
        public MlbGameLinescoreTeam team { get; set; }
    }

    public class MlbGameLinescore
    {

        [JsonProperty("copyright")]
        public string copyright { get; set; }

        [JsonProperty("currentInning")]
        public int currentInning { get; set; }

        [JsonProperty("currentInningOrdinal")]
        public string currentInningOrdinal { get; set; }

        [JsonProperty("inningState")]
        public string inningState { get; set; }

        [JsonProperty("inningHalf")]
        public string inningHalf { get; set; }

        [JsonProperty("isTopInning")]
        public bool isTopInning { get; set; }

        [JsonProperty("scheduledInnings")]
        public int scheduledInnings { get; set; }

        [JsonProperty("innings")]
        public IList<Innings> innings { get; set; }

        [JsonProperty("teams")]
        public MlbGameLinescoreTeams teams { get; set; }

        [JsonProperty("defense")]
        public MlbGameLinescoreDefense defense { get; set; }

        [JsonProperty("offense")]
        public MlbGameLinescoreOffense offense { get; set; }

        [JsonProperty("balls")]
        public int balls { get; set; }

        [JsonProperty("strikes")]
        public int strikes { get; set; }

        [JsonProperty("outs")]
        public int outs { get; set; }
    }
}