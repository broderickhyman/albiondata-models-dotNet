using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbionData.Models
{
  public class GoldPrice
  {
    [Column("id")]
    [JsonIgnore]
    public ulong Id { get; set; }

    [Column("price")]
    public uint Price { get; set; }

    [Column("timestamp")]
    public DateTime Timestamp { get; set; }
  }

  public class GoldPriceUpload
  {
    public uint[] Prices;
    public long[] Timestamps;
  }
}
