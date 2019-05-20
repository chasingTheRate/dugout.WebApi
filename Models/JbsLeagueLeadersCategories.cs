using Newtonsoft.Json;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models {
  public class JbsLeagueLeadersCategories {

    public ObjectId id { get; set; }
    public string statGroup { get; set; }
    public List<string> categories;
  }
}
