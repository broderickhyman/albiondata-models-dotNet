using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbionData.Models
{
  public static class Locations
  {
    private static readonly Dictionary<Location, string> names = new Dictionary<Location, string>
    {
      {Location.SwampCross, "Swamp Cross" },
      {Location.Thetford, "Thetford" },
      {Location.MorganasRest, "Morganas Rest" },
      {Location.Lymhurst, "Lymhurst" },
      {Location.ForestCross, "Forest Cross" },
      {Location.MerlynsRest, "Merlyns Rest" },
      {Location.SteppeCross, "Steppe Cross" },
      {Location.Bridgewatch, "Bridgewatch" },
      {Location.HighlandCross, "Highland Cross" },
      {Location.BlackMarket, "Black Market" },
      {Location.Caerleon, "Caerleon" },
      {Location.Martlock, "Martlock" },
      {Location.Caerleon2, "Caerleon 2" },
      {Location.FortSterling, "Fort Sterling" },
      {Location.MountainCross, "Mountain Cross" },
      {Location.ArthursRest, "Arthurs Rest" }
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
    MorganasRest = 8,
    Lymhurst = 1002,
    ForestCross = 1006,
    MerlynsRest = 1012,
    SteppeCross = 2002,
    Bridgewatch = 2004,
    HighlandCross = 3002,
    BlackMarket = 3003,
    Caerleon = 3005,
    Martlock = 3008,
    Caerleon2 = 3013,
    FortSterling = 4002,
    MountainCross = 4006,
    ArthursRest = 4300
  }
}
