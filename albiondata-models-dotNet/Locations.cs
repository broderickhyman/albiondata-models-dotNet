using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbionData.Models
{
  public static class Locations
  {
    private static readonly Dictionary<Location, string> names = new Dictionary<Location, string>
    {
      {Location.Thetford, "Thetford" },
      {Location.SwampCross, "Swamp Cross" },
      {Location.Lymhurst, "Lymhurst" },
      {Location.ForestCross, "Forest Cross" },
      {Location.Bridgewatch, "Bridgewatch" },
      {Location.SteppeCross, "Steppe Cross" },
      {Location.HighlandCross, "Highland Cross" },
      {Location.BlackMarket, "Black Market" },
      {Location.Martlock, "Martlock" },
      {Location.Caerleon, "Caerleon" },
      {Location.FortSterling, "Fort Sterling" },
      {Location.MountainCross, "Mountain Cross" }
    };

    public static string GetName(Location location)
    {
      if (names.TryGetValue(location, out var name))
      {
        return name;
      }
      return "Unknown";
    }

    public static string GetName(int locationId)
    {
      return GetName((Location)locationId);
    }
  }

  public enum Location
  {
    Thetford = 0,
    SwampCross = 4,
    Lymhurst = 1000,
    ForestCross = 1006,
    Bridgewatch = 2000,
    SteppeCross = 2002,
    HighlandCross = 3002,
    BlackMarket = 3003,
    Martlock = 3004,
    Caerleon = 3005,
    FortSterling = 4000,
    MountainCross = 4006
  }
}
