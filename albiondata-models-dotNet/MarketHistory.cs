using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbionData.Models
{
  public class MarketHistory
  {
    [Column("item_amount")]
    [Required]
    public ulong ItemAmount { get; set; }

    [Column("silver_amount")]
    [Required]
    public ulong SilverAmount { get; set; }

    [NotMapped]
    public ulong Timestamp { get; set; }
  }

  public class MarketHistoryDB : MarketHistory
  {
    [Column("id")]
    [JsonIgnore]
    public ulong Id { get; set; }

    [Column("item_id")]
    [MaxLength(128)]
    [Required]
    public string ItemTypeId { get; set; }

    [Column("location")]
    [Required]
    public ushort Location { get; set; }

    [Column("quality")]
    [Required]
    public byte QualityLevel { get; set; }

    [Column("timestamp")]
    [Required]
    public new DateTime Timestamp { get; set; }
  }

  public class MarketHistoriesUpload
  {
    public uint AlbionId;
    public string AlbionIdString;
    public ushort LocationId;
    public byte QualityLevel;
    public Timescale Timescale;
    public List<MarketHistory> MarketHistories = new List<MarketHistory>();
  }

  public class MarketHistoriesResponse
  {
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    [JsonProperty(PropertyName = "item_id")]
    public string ItemTypeId { get; set; }

    [JsonProperty(PropertyName = "quality")]
    public byte QualityLevel { get; set; }

    [JsonProperty(PropertyName = "data")]
    public List<MarketHistoryResponse> Data { get; set; } = new List<MarketHistoryResponse>();
  }

  public class MarketHistoryResponse
  {
    [JsonProperty(PropertyName = "item_count")]
    public ulong ItemCount { get; set; }

    [JsonProperty(PropertyName = "avg_price")]
    public ulong AveragePrice { get; set; }

    [JsonProperty(PropertyName = "timestamp")]
    public DateTime Timestamp { get; set; }
  }

  public enum Timescale
  {
    Day,
    Week,
    Month
  }
}
