using ChartIntegration.Shared;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ChartIntegration
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton<IDataLayer, DataLayer>();
    }

    public void Configure(IComponentsApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
