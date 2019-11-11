using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Shared
{
  public class City
  {
    public string CityName { get; set; }
    public int Population { get; set; }
  }

  public class Country
  {
    public string CountryName { get; set; }
    public City[] Cities { get; set; }
  }

  public static class DemoData
  {
    public static List<Country> Data { get; } = new List<Country> {
      new Country {
        CountryName = "UK",
        Cities = new City[] {
          new City { CityName="London", Population=7556900 },
          new City { CityName="Edinburgh", Population=464990 }
        }
      },
      new Country {
        CountryName = "USA",
        Cities = new City[] {
          new City { CityName="New York", Population=8601186 }
        }
      }
    };
  }

  public class TransformResult
  {
    public string CountryName { get; set; }
    public string CityName { get; set; }
    public int Population { get; set; }
  }
}

