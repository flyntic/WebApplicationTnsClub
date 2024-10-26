
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WebApplicationTnsClub;
using WebApplicationTnsClub.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

string connectionString = "Host=localhost;Port=5432;Database=tennisclub_2;Username=postgres;Password='09870'";

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString),
    optionsLifetime: ServiceLifetime.Singleton);

builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

var app = builder.Build();

app.UseDefaultFiles();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
// app.UseSwagger();
//  app.UseSwaggerUI();
//}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseHttpsRedirection();

app.Environment.WebRootPath = "c://wwwroot";
// for the wwwroot/uploads folder
string uploadsDir = Path.Combine(app.Environment.WebRootPath, "uploads");
if (!Directory.Exists(uploadsDir))
    Directory.CreateDirectory(uploadsDir);

app.UseStaticFiles(new StaticFileOptions()
{
    RequestPath = "/images",
    FileProvider = new PhysicalFileProvider(uploadsDir)
});


app.UseRouting();

/*
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
*/

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    if (app.Environment.IsDevelopment())
    {
        spa.UseAngularCliServer(npmScript: "start");
    }
});


app.UseAuthorization();

app.Run();

