using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace AlbionData.Models
{
  public class MarketStat
  {
    [Column("id")]
    public ulong Id { get; set; }

    [Column("item_id")]
    [MaxLength(128)]
    public string ItemId { get; set; }

    [Column("location")]
    [MaxLength(128)]
    public ushort LocationId { get; set; }

    [Column("price_avg")]
    public decimal PriceAverage { get; set; }

    [Column("price_max")]
    public ulong PriceMax { get; set; }

    [Column("price_min")]
    public ulong PriceMin { get; set; }

    [Column("timestamp")]
    public DateTime TimeStamp { get; set; }
  }

  public class MarketStatResponse
  {
    [JsonProperty(PropertyName = "timestamps")]
    public List<ulong> TimeStamps { get; set; }

    [JsonProperty(PropertyName = "prices_min")]
    public List<ulong> PricesMin { get; set; }

    [JsonProperty(PropertyName = "prices_max")]
    public List<ulong> PricesMax { get; set; }

    [JsonProperty(PropertyName = "prices_avg")]
    public List<decimal> PricesAvg { get; set; }
  }

  public class MarketStatChartResponse
  {
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    [JsonProperty(PropertyName = "data")]
    public MarketStatResponse Data { get; set; }
  }
}
