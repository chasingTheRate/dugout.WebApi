
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models{

 public class RosterPerson
  {
    [BsonId]
    public int id { get; set; }

    [BsonElement("fullName")]
    public string fullName { get; set; }

    [BsonElement("link")]
    public string link { get; set; }
  }

  public class Position
  {
    
    [BsonElement("code")]
    public string code { get; set; }

    [BsonElement("name")]
    public string name { get; set; }

    [BsonElement("type")]
    public string type { get; set; }

    [BsonElement("abbreviation")]
    public string abbreviation { get; set; }
  }

  public class Status
  {
    
    [BsonElement("code")]
    public string code { get; set; }

    [BsonElement("description")]
    public string description { get; set; }
  }

  public class Roster
  {
    public Roster()
    {
       Id = ObjectId.GenerateNewId();
    }
    public ObjectId Id { get; set; }

    [BsonElement("person")]
    public RosterPerson person { get; set; }

    [BsonElement("jerseyNumber")]
    public string jerseyNumber { get; set; }

    [BsonElement("position")]
    public Position position { get; set; }

    [BsonElement("status")]
    public Status status { get; set; }

    [BsonElement("parentTeamId")]
    public int parentTeamId { get; set; }
  }

  public class MlbRosters
  {
    
    [BsonElement("copyright")]
    public string copyright { get; set; }

    [BsonElement("roster")]
    public IList<Roster> roster { get; set; }

    [BsonElement("link")]
    public string link { get; set; }

    [BsonId]
    [BsonElement("teamId")]
    public int teamId { get; set; }

    [BsonElement("rosterType")]
    public string rosterType { get; set; }
  }
}