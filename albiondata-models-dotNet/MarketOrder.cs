using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace AlbionData.Models
{
  public class MarketOrder
  {
    [Column("id")]
    public ulong Id { get; set; }

    [Column("item_id")]
    [MaxLength(128)]
    public string ItemTypeId { get; set; }

    [Column("location")]
    [Required]
    public ushort LocationId { get; set; }

    [Column("quality_level")]
    public byte QualityLevel { get; set; }

    [Column("enchantment_level")]
    public byte EnchantmentLevel { get; set; }

    [Column("price")]
    public ulong UnitPriceSilver { get; set; }

    [Column("amount")]
    public uint Amount { get; set; }

    [Column("auction_type")]
    [MaxLength(32)]
    public string AuctionType { get; set; }

    [Column("expires")]
    public DateTime Expires { get; set; }

    [NotMapped]
    //[Column("group_id")]
    [MaxLength(128)]
    public string ItemGroupTypeId { get; set; }
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
    [Required]
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
