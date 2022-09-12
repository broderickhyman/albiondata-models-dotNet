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
      {Location.ThetfordPortal, "Thetford Portal" },
      {Location.MorganasRest, "Morganas Rest" },
      {Location.Lymhurst, "Lymhurst" },
      {Location.LymhurstPortal, "Lymhurst Portal" },
      {Location.ForestCross, "Forest Cross" },
      {Location.MerlynsRest, "Merlyns Rest" },
      {Location.SteppeCross, "Steppe Cross" },
      {Location.Bridgewatch, "Bridgewatch" },
      {Location.BridgewatchPortal, "Bridgewatch Portal" },
      {Location.HighlandCross, "Highland Cross" },
      {Location.BlackMarket, "Black Market" },
      {Location.Caerleon, "Caerleon" },
      {Location.Caerleon2, "Caerleon 2" },
      {Location.Martlock, "Martlock" },
      {Location.MartlockPortal, "Martlock Portal" },
      {Location.FortSterling, "Fort Sterling" },
      {Location.FortSterlingPortal, "Fort Sterling Portal" },
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
    
    public static List<string> GetNames()
    {
        return names.Values.ToList();
    }
  }

  public enum Location
  {
    SwampCross = 4,
    Thetford = 7,
    ThetfordPortal = 301,
    MorganasRest = 8,
    Lymhurst = 1002,
    LymhurstPortal = 1301,
    ForestCross = 1006,
    MerlynsRest = 1012,
    SteppeCross = 2002,
    Bridgewatch = 2004,
    BridgewatchPortal = 2301,
    HighlandCross = 3002,
    BlackMarket = 3003,
    Caerleon = 3005,
    Martlock = 3008,
    MartlockPortal = 3301,
    Caerleon2 = 3013,
    FortSterling = 4002,
    FortSterlingPortal = 4301,
    MountainCross = 4006,
    ArthursRest = 4300
  }
}
