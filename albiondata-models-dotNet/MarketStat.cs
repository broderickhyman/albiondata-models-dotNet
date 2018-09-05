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
    public double PriceAverage { get; set; }

    [Column("price_max")]
    public ulong PriceMax { get; set; }

    [Column("price_min")]
    public ulong PriceMin { get; set; }

    [Column("timestamp")]
    public DateTime TimeStamp { get; set; }
  }

  public class MarketStatResponse
  {
    [DataMember(Name = "timestamps")]
    public List<ulong> TimeStamps { get; set; }

    [DataMember(Name = "prices_min")]
    public List<ulong> PricesMin { get; set; }

    [DataMember(Name = "prices_max")]
    public List<ulong> PricesMax { get; set; }

    [DataMember(Name = "prices_avg")]
    public List<double> PricesAvg { get; set; }
  }

  public class MarketStatChartResponse
  {
    [DataMember(Name = "location")]
    public string Location { get; set; }

    [DataMember(Name = "data")]
    public MarketStatResponse Data { get; set; }
  }
}
