using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbionData.Models
{
  public class GoldPrice
  {
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("id")]
    public ulong Id { get; set; }

    [Column("price")]
    public uint Price { get; set; }

    [Column("timestamp")]
    public DateTime Timestamp { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }

  public class GoldPriceUpload
  {
    public uint[] Prices;
    public long[] Timestamps;
  }
}
