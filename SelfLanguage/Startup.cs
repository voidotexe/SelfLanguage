/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SelfLanguage.Data;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System;

namespace SelfLanguage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(Environment.GetEnvironmentVariable("SelfLanguage__ConnectionString"))
            );

            services.AddDefaultIdentity<User>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<UserDbContext>();

            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<ITranscriptionService, TranscriptionService>();
            services.AddScoped<ISubtitleService, SubtitleService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // File serving

            app.UseStaticFiles();

            // Route

            app.UseRouting();

            // Auth

            app.UseAuthentication();
            app.UseAuthorization();

            // MVC

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "create",
                    pattern: "create/video",
                    defaults: new { controller = "Create",  action = "Video" }
                );

                endpoints.MapControllerRoute(
                    name: "home",
                    pattern: "/",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });
        }
    }
}
