using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionData.Models
{
  public class MarketHistory
  {
    public ulong ItemAmount;
    public ulong SilverAmount;
    public ulong Timestamp;
  }

  public class MarketHistoriesUpload
  {
    public uint AlbionId;
    public int LocationId;
    public byte QualityLevel;
    public Timescale Timescale;
    public List<MarketHistory> MarketHistories = new List<MarketHistory>();
  }

  public enum Timescale
  {
    Hours,
    Days,
    Weeks
  }
}
