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

  public enum Timescale
  {
    Day,
    Week,
    Month
  }
}
