using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.FileProviders;
using WebApplicationTnsClub.DB;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationTnsClub.Extensions
{
    public static class BuildExtension
    {
        public static WebApplication BuildWithSpa(this WebApplicationBuilder builder)
        { 
            var app=builder.Build();

         //   if (app.Environment.IsDevelopment())
         //   {
          //      app.UseDeveloperExceptionPage();
          //  }
            app.UseStaticFiles();

            if (app.Environment.IsDevelopment())
            {
          //      app.UseSpaStaticFiles();
            }
            // Configure the HTTP request pipeline.
          //  if (app.Environment.IsDevelopment())
           // {
          //    app.UseSwagger();
           ///   app.UseSwaggerUI();
           // }
           // app.UseHttpsRedirection();

            app.Environment.WebRootPath = "c://wwwroot";
            // for the wwwroot/uploads folder
            string uploadsDir = Path.Combine(app.Environment.WebRootPath, "images");
            if (!Directory.Exists(uploadsDir))
                Directory.CreateDirectory(uploadsDir);

            app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = "/images",
                FileProvider = new PhysicalFileProvider(uploadsDir)
            });
        
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(_ => {  });
        /*    app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });*/

            app.Use((ctx, next) =>
            {
                if(ctx.Request.Path.StartsWithSegments("/api"))
                {
                    ctx.Response.StatusCode = 404;
                    return Task.CompletedTask;
                }
                return next();
            });
            // app.UseSpa(x => { x.UseProxyToSpaDevelopmentServer("http://127.0.0.1:7094"); });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501
                spa.Options.SourcePath = "ClientApp";

                if (app.Environment.IsDevelopment())
                { //
                    spa.UseAngularCliServer(npmScript: "start");
               }
            });

            using var scope=app.Services.CreateScope();
            IdentityUser admin = null;
            var userManager=scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            if (!userManager.Users.Any(x => x.UserName == "admin"))
            {
                admin=new IdentityUser() { UserName = "admin" };
                userManager.CreateAsync(admin,"password").GetAwaiter().GetResult();
                userManager.AddClaimAsync(admin, new System.Security.Claims.Claim("level","admin")).GetAwaiter().GetResult();    
            }

            var database=scope.ServiceProvider.GetRequiredService<ApplicationContext>();

       /*     if (!database.Projects.Any())
            {
                database.Projects.Add(new Project()
                {
                    Tasks = new List<WorkTask>()
                    {
                        new WorkTask() { Title = "Clean Dog" },
                        new WorkTask() { Title = "Buy Food" },
                    },
                    Users=new List<ProjectUser>() { new ProjectUser() { UserId = admin.Id } }
                });
                database.Projects.Add(new Project()
                {
                    Tasks = new List<WorkTask>()
                    {
                        new WorkTask() { Title = "Refactor" },
                        new WorkTask() { Title = "Inject" },
                    }
                });
                database.SaveChanges();

            }*/

            return app;

        }
    }
}
