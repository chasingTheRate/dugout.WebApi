
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dugout.WebApi.Models{

  public class PrimaryPosition
  {
    public PrimaryPosition()
    {
       Id = ObjectId.GenerateNewId();
    }
    public ObjectId Id { get; set; }

    [BsonElement("fullName")]
    public string code { get; set; }
    [BsonElement("name")]
    public string name { get; set; }
    [BsonElement("type")]
    public string type { get; set; }
    [BsonElement("abbreviation")]
    public string abbreviation { get; set; }
  }

  public class BatSide
  {
    public BatSide()
    {
       Id = ObjectId.GenerateNewId();
    }
    public ObjectId Id { get; set; }

    [BsonElement("code")]
    public string code { get; set; }
    [BsonElement("description")]
    public string description { get; set; }
  }

  public class PitchHand
  {
    public PitchHand()
    {
       Id = ObjectId.GenerateNewId();
    }
    public ObjectId Id { get; set; }

    [BsonElement("code")]
    public string code { get; set; }
    [BsonElement("description")]
    public string description { get; set; }
  }

  public class Person
  {
    [BsonId]
    public int id { get; set; }
    [BsonElement("fullName")]
    public string fullName { get; set; }
    [BsonElement("link")]
    public string link { get; set; }
    [BsonElement("firstName")]
    public string firstName { get; set; }
    [BsonElement("lastName")]
    public string lastName { get; set; }
    [BsonElement("primaryNumber")]
    public string primaryNumber { get; set; }
    [BsonElement("birthDate")]
    public string birthDate { get; set; }
    [BsonElement("currentAge")]
    public int currentAge { get; set; }
    [BsonElement("birthCity")]
    public string birthCity { get; set; }
    [BsonElement("birthCountry")]
    public string birthCountry { get; set; }
    [BsonElement("height")]
    public string height { get; set; }
    [BsonElement("weight")]
    public int weight { get; set; }
    [BsonElement("active")]
    public bool active { get; set; }
    [BsonElement("primaryPosition")]
    public PrimaryPosition primaryPosition { get; set; }
    [BsonElement("useName")]
    public string useName { get; set; }
    [BsonElement("middleName")]
    public string middleName { get; set; }
    [BsonElement("boxscoreName")]
    public string boxscoreName { get; set; }
    [BsonElement("nickName")]
    public string nickName { get; set; }
    [BsonElement("pronunciation")]
    public string pronunciation { get; set; }
    [BsonElement("mlbDebutDate")]
    public string mlbDebutDate { get; set; }
    [BsonElement("batSide")]
    public BatSide batSide { get; set; }
    [BsonElement("pitchHand")]
    public PitchHand pitchHand { get; set; }
    [BsonElement("nameFirstLast")]
    public string nameFirstLast { get; set; }
    [BsonElement("nameSlug")]
    public string nameSlug { get; set; }
    [BsonElement("firstLastName")]
    public string firstLastName { get; set; }
    [BsonElement("lastFirstName")]
    public string lastFirstName { get; set; }
    [BsonElement("lastInitName")]
    public string lastInitName { get; set; }
    [BsonElement("initLastName")]
    public string initLastName { get; set; }
    [BsonElement("fullFMLName")]
    public string fullFMLName { get; set; }
    [BsonElement("fullLFMName")]
    public string fullLFMName { get; set; }
    [BsonElement("strikeZoneTop")]
    public double strikeZoneTop { get; set; }
    [BsonElement("strikeZoneBottom")]
    public double strikeZoneBottom { get; set; }
  }

  public class MlbPlayer
  {
    [BsonElement("copyright")]
    public string copyright { get; set; }
    [BsonElement("people")]
    public IList<Person> people { get; set; }
  }
}