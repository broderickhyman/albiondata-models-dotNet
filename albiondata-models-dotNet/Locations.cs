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
      return null;
    }

    public static string GetName(int locationId)
    {
      return GetName((Location)locationId) ?? locationId.ToString();
    }
  }

  public enum Location
  {
    SwampCross = 4,
    Thetford = 7,
    Lymhurst = 1002,
    ForestCross = 1006,
    SteppeCross = 2002,
    Bridgewatch = 2004,
    HighlandCross = 3002,
    BlackMarket = 3003,
    Caerleon = 3005,
    Martlock = 3008,
    FortSterling = 4002,
    MountainCross = 4006
  }
}
