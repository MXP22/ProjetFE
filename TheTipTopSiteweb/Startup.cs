
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Google;
using TheTipTopSiteweb.Models;

namespace TheTipTopSiteweb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
            string connectionString = "server=127.0.0.1;Port=3307; database=thetiptoptest ; user=root ; password=momo";


            //services.AddAuthentication(option =>
            //{
            //    option.DefaultAuthenticateScheme = GoogleDefaults.AuthenticationScheme;
            //    option.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;


            //});


            services.AddAuthentication()

               .AddGoogle(options =>
               {
                   IConfigurationSection googleAuthNSection =
                        Configuration.GetSection("Authentication:Google");

                   options.ClientId = "911294321851-l0lg84ndaj6fpbvurl4sanp2j2ib6rd8.apps.googleusercontent.com";
                   options.ClientSecret = "XY-9Tg6uoqBZd7sxgNCsS7Xz";
               }).AddFacebook(facebookOptions =>



               {
                   facebookOptions.AppId = "550483226308051"; // Configuration["Authentication:Facebook:AppId"];
                   facebookOptions.AppSecret = "76462818339808ba74dc24487252c34c";//Configuration["Authentication:Facebook:AppSecret"];
                   facebookOptions.AccessDeniedPath = "/AccessDeniedPathInfo";
               });
            //services.AddIdentity<User, Role>(option =>
            //{
            //    option.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<ThetiptoptestContext>();

            services.AddDbContext<thetiptoptestContext>(
         dbContextOptions => dbContextOptions
             .UseMySql(connectionString, serverVersion)
             .EnableSensitiveDataLogging() // <-- These two calls are optional but help
             .EnableDetailedErrors()      // <-- with debugging (remove for production).
             .EnableDetailedErrors()       // <-- with debugging (remove for production).
     );

            services.AddControllersWithViews();
            services.AddMvcCore();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();



            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
