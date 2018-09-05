using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
}
