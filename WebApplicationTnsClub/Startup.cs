﻿    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.AspNetCore.SpaServices.AngularCli;
    using Microsoft.EntityFrameworkCore;
    using WebApplicationTnsClub.Models;
using Microsoft.Extensions.Options;

namespace WebApplicationTnsClub
{
         public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
             string connectionString = "Host=localhost;Port=5432;Database=tennisclub;Username=postgres;Password='09870'";
 
               services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

            services.AddControllers();
                services.AddSpaStaticFiles(configuration =>
                {
                    configuration.RootPath = "ClientApp/dist";
                });
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                app.UseStaticFiles();
                if (!env.IsDevelopment())
                {
                    app.UseSpaStaticFiles();
                }
                 app.UseRouting();

                 app.UseEndpoints(endpoints =>
                 {
                       endpoints.MapControllers();
                 });
                
                app.UseSpa(spa =>
                {
                    spa.Options.SourcePath = "ClientApp";

                    if (env.IsDevelopment())
                    {
                        spa.UseAngularCliServer(npmScript: "start");
                    }
                });
            }
        }
    
}
