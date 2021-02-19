using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Demo.Shared
{
  public interface IDataLayer
  {
    Task<Country[]> FetchCountries(string sortField, bool sortDesc);
  }

  public class DataLayer : IDataLayer
  {
    public DataLayer(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    HttpClient httpClient;

    public async Task<Country[]> FetchCountries(string sortField, bool sortDesc)
    {
      var url = $"https://outlier.oliversturm.com/countries?sort[0][selector]={sortField}&sort[0][desc]={sortDesc}&take=10";
      var data = await httpClient.GetJsonAsync<Data>(url);
      return data.data;
    }
  }
}
