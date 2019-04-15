using AlbionData.Models;
using System;
using Xunit;

namespace albiondata_models_tests
{
  public class LocationsTests
  {
    [Theory]
    [InlineData("0", 0)]
    [InlineData("9999", 9999)]
    public void UnknownLocationReturnsId(string name, int id)
    {
      Assert.Equal(name, Locations.GetName(id));
    }
  }
}
