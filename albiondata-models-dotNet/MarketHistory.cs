using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionData.Models
{
  public class MarketHistory
  {
    public uint ItemAmount;
    public uint SilverAmount;
    public uint Timestamp;
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
