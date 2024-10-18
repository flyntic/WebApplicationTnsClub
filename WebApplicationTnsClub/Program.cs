
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using WebApplicationTnsClub;
public class Program
{
    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }
    public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
}

/*
using Microsoft.AspNetCore;


internal class Program
{

    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }
    public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
*/
    /*  private static void Main(string[] args)
      {
          var builder = WebApplication.CreateBuilder(args);
          builder.Services.AddSpaStaticFiles(configuration =>
          {
              configuration.RootPath = "Client.App/dist";
          });

          var app = builder.Build();

          IConfiguration configuration = app.Configuration;
          IWebHostEnvironment env = app.Environment;

          if (env.IsDevelopment())
          {
              app.UseDeveloperExceptionPage();
          }

          app.UseStaticFiles();
          if (!env.IsDevelopment())
          {
              app.UseSpaStaticFiles();
          }
          app.UseSpa(spa =>
          {
              spa.Options.SourcePath = "Client.App";

              if (env.IsDevelopment())
              {
                  spa.UseAngularCliServer(npmScript: "start");
              }
          });



          app.UseDefaultFiles();
          app.UseStaticFiles();

          // Configure the HTTP request pipeline.
          //if (app.Environment.IsDevelopment())
          //{
          // app.UseSwagger();
          //  app.UseSwaggerUI();
          //}

          //app.UseHttpsRedirection();

          //app.UseAuthorization();

          //app.MapControllers();

          app.MapGet("/index.html");
          //app.MapFallbackToFile("/index.html");

          app.Run();
      }
}*/
/*

 var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();

 */