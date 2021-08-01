using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheTipTopSiteweb.Data;

[assembly: HostingStartup(typeof(TheTipTopSiteweb.Areas.Identity.IdentityHostingStartup))]
namespace TheTipTopSiteweb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TheTipTopSitewebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TheTipTopSitewebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TheTipTopSitewebContext>();
            });
        }
    }
}