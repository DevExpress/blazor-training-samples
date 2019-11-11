using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Shared {
  public interface IDataLayer {
    Task<Country[]> FetchCountries(string sortField, bool sortDesc);
  }

  public class DataLayer : IDataLayer {
    public DataLayer(IHttpClientFactory httpClientFactory) => this.httpClientFactory = httpClientFactory;

    private readonly IHttpClientFactory httpClientFactory;

    public async Task<Country[]> FetchCountries(string sortField, bool sortDesc) {
      string url = $"http://outlier.oliversturm.com:8080/countries?sort[0][selector]={sortField}&sort[0][desc]={sortDesc}&take=10";
      var client = httpClientFactory.CreateClient();
      var response = await client.GetAsync(url);
      using (var responseStream = await response.Content.ReadAsStreamAsync()) {
        var data = await JsonSerializer.DeserializeAsync<Data>(responseStream);
        return data.data;
      }
    }
  }
}
