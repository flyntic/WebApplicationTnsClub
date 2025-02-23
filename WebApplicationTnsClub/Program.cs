
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WebApplicationTnsClub;
using WebApplicationTnsClub.DB;
using WebApplicationTnsClub.Models;

using System.Security.Claims;
using WebApplicationTnsClub.Endpoints;
using WebApplicationTnsClub.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

string connectionString = "Host=localhost;Port=5432;Database=tennisclub_11;Username=postgres;Password='09870'";

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString),
    optionsLifetime: ServiceLifetime.Singleton);

builder.Services.AddIdentity<IdentityUser,IdentityRole>(options=>
          {
              if (builder.Environment.IsDevelopment()) { 
                  options.User.RequireUniqueEmail = false;
                  options.Password.RequiredLength = 1;
                  options.Password.RequireDigit = false;
                  options.Password.RequireLowercase = false;
                  options.Password.RequireUppercase = false;
                  options.Password.RequireNonAlphanumeric   = false;

              } 
          
          })
               .AddEntityFrameworkStores<ApplicationContext>()
               .AddDefaultTokenProviders();



builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});


builder.Services.AddAuthentication("cookie").AddCookie("cookie");

/*
builder.Services.AddAuthorization( options =>
{
    options.AddPolicy("manager", pb => pb
        .RequireClaim("level", "manager","admin"));

    options.AddPolicy("admin", pb => pb
        .RequireClaim("level", "admin"));
});

*/

var app = builder.BuildWithSpa();

app.UseEndpoints(endpoints =>
{
    endpoints?.MapControllers();
});


var apiEndpoints = app.MapGroup("/api");


apiEndpoints.MapGet("/user", UserEndPoint.Handler);

apiEndpoints.MapPost("/login", LoginEndPoint.Handler);

apiEndpoints.MapPost("/register", RegisterEndPoint.Handler);

apiEndpoints.MapGet("/logout", LogoutEndPoint.Handler);//.RequireAuthorization();



app.UseEndpoints(endpoints =>
{
    endpoints?.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});



app.Run();

