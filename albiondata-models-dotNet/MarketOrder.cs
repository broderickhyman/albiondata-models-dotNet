using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbionData.Models
{
  public class MarketOrder
  {
    public ulong Id { get; set; }
    public string ItemTypeId { get; set; }
    public ushort LocationId { get; set; }
    public byte QualityLevel { get; set; }
    public byte EnchantmentLevel { get; set; }
    public ulong UnitPriceSilver { get; set; }
    public uint Amount { get; set; }
    public string AuctionType { get; set; }
    public DateTime Expires { get; set; }

    [NotMapped]
    public string ItemGroupTypeId { get; set; }

    public override string ToString()
    {
      return $"{Id}{Amount}";
    }
  }

  public class MarketUpload
  {
    public List<MarketOrder> Orders = new List<MarketOrder>();
  }

  public class MarketOrderDB : MarketOrder
  {
    [Column("albion_id")]
    public ulong AlbionId { get; set; }

    [Column("initial_amount")]
    public uint InitialAmount { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    public override string ToString()
    {
      return $"{AlbionId} - {ItemTypeId} at {LocationId}";
    }
  }
}
