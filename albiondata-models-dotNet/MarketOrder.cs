using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
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

    public string GetUniqueKey()
    {
      return $"{Id}|{Amount}|{UnitPriceSilver}";
    }
  }

  public class MarketUpload
  {
    public List<MarketOrder> Orders = new List<MarketOrder>();
  }

  public class MarketResponse
  {
    [JsonProperty(PropertyName = "item_id")]
    public string ItemTypeId { get; set; }

    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    [JsonProperty(PropertyName = "quality")]
    public byte QualityLevel { get; set; }

    [JsonProperty(PropertyName = "sell_price_min")]
    public ulong SellPriceMin { get; set; }

    [JsonProperty(PropertyName = "sell_price_min_date")]
    public DateTime SellPriceMinDate { get; set; }

    [JsonProperty(PropertyName = "sell_price_max")]
    public ulong SellPriceMax { get; set; }

    [JsonProperty(PropertyName = "sell_price_max_date")]
    public DateTime SellPriceMaxDate { get; set; }

    [JsonProperty(PropertyName = "buy_price_min")]
    public ulong BuyPriceMin { get; set; }

    [JsonProperty(PropertyName = "buy_price_min_date")]
    public DateTime BuyPriceMinDate { get; set; }

    [JsonProperty(PropertyName = "buy_price_max")]
    public ulong BuyPriceMax { get; set; }

    [JsonProperty(PropertyName = "buy_price_max_date")]
    public DateTime BuyPriceMaxDate { get; set; }
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
