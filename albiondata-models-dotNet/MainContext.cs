using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionData.Models
{
  public class MainContext : DbContext
  {
    public DbSet<GoldPrice> GoldPrices { get; set; }
    public DbSet<MarketOrderDB> MarketOrders { get; set; }
    public DbSet<MarketStat> MarketStats { get; set; }
    public DbSet<MarketHistoryDB> MarketHistories { get; set; }
    public string DatabaseConnectionUrl { get; set; }

    public MainContext() { }

    public MainContext(DbContextOptions<MainContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<MarketOrderDB>(entity =>
      {
        entity.ToTable("market_orders");
        entity.HasKey(e => e.Id);
        entity.HasAlternateKey(e => e.AlbionId)
              .HasName("AlbionId");

        entity.HasIndex(e => new { e.ItemTypeId, e.AuctionType, e.LocationId, e.UpdatedAt, e.DeletedAt })
              .HasName("Main");
        entity.HasIndex(e => new { e.ItemTypeId, e.UpdatedAt, e.DeletedAt })
              .HasName("TypeId");
        entity.HasIndex(e => e.DeletedAt)
              .HasName("Deleted");
        entity.HasIndex(e => new { e.DeletedAt, e.Expires, e.UpdatedAt })
              .HasName("Expired");
      });

      modelBuilder.Entity<MarketStat>(entity =>
      {
        entity.ToTable("market_stats");
        entity.HasKey(e => e.Id);
        entity.HasAlternateKey(e => new { e.ItemId, e.Location, e.Timestamp });
      });

      modelBuilder.Entity<MarketHistoryDB>(entity =>
      {
        entity.ToTable("market_history");
        entity.HasKey(e => e.Id);
        entity.HasAlternateKey(e => new { e.ItemTypeId, e.QualityLevel, e.Location, e.Timestamp })
              .HasName("Main");
      });

      modelBuilder.Entity<GoldPrice>(entity =>
      {
        entity.ToTable("gold_prices");
        entity.HasKey(e => e.Id);
        entity.HasIndex(e => new { e.Timestamp, e.DeletedAt });
      });
    }
  }
}
