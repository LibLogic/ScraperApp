using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScraperApp.Areas.Identity.Data;
using ScraperApp.Data;

[assembly: HostingStartup(typeof(ScraperApp.Areas.Identity.IdentityHostingStartup))]
namespace ScraperApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ScraperAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ScraperAppContextConnection")));
                services.AddDefaultIdentity<ScraperAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ScraperAppContext>();
            });
        }
    }
}