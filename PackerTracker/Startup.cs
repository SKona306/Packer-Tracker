using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PackerTracker
{
  public class Startup
  {
    public Startup(IWebHostEnviroment env)
    {
      var builder = new ConfigurationBulder()
        .SetBasePath(env.ContentRootPath)
        .AddEnviromentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseRouting();

      app.UseEndPoints(routes => 
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}

