
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
//var builder = WebApplication.CreateBuilder();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

string connectionString = "Host=localhost;Port=5432;Database=tennisclub_8;Username=postgres;Password='09870'";

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString),
    optionsLifetime: ServiceLifetime.Singleton);

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options=>
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

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//typeof(Startup)

builder.Services.AddAuthentication("cookie").AddCookie("cookie");

builder.Services.AddAuthorization( options =>
{
    options.AddPolicy("manager", pb => pb
        .RequireClaim("level", "manager","admin"));

    options.AddPolicy("admin", pb => pb
        .RequireClaim("level", "admin"));
});


////---------------------
//app.UseDefaultFiles();

/*
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
string uploadsDir = Path.Combine(app.Environment.WebRootPath, "images");
if (!Directory.Exists(uploadsDir))
    Directory.CreateDirectory(uploadsDir);

app.UseStaticFiles(new StaticFileOptions()
{
    RequestPath = "/images",
    FileProvider = new PhysicalFileProvider(uploadsDir)
});
*/
//app.UseAuthentication();
//app.UseAuthorization();
//app.UseRouting();


var app = builder.BuildWithSpa();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

/*
var apiEndpoints = app.MapGroup("/api");

//apiEndpoints.MapGet("/", () => "hello");

apiEndpoints.MapGet("/user", UserEndPoint.Handler);

apiEndpoints.MapPost("/login", LoginEndPoint.Handler);

apiEndpoints.MapPost("/register", RegisterEndPoint.Handler);

apiEndpoints.MapGet("/logout", LogoutEndPoint.Handler).RequireAuthorization();


apiEndpoints.MapGet("/projects", ProjectEndPoint.List)
    .RequireAuthorization();
apiEndpoints.MapGet("/projects/{id:int}", ProjectEndPoint.Get)
    .RequireAuthorization();
apiEndpoints.MapPost("/projects/{id:int}/add-user/{userId:guid}", ProjectEndPoint.AddUserToProject)
    .RequireAuthorization("manager");
apiEndpoints.MapPost("/promote/{userId:guid}", PromoteEndPoint.PromoteUser)
    .RequireAuthorization("admin");*/
//var builder = WebApplication.CreateBuilder();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie();


//var app = builder.Build();

//app.UseAuthentication();
/*
app.MapGet("/login/{username}", async (string username, HttpContext context) =>
{
    var claims = new List<Claim> { new(ClaimTypes.Name, username) };
    var claimsIdentity = new ClaimsIdentity(claims, "cookie");
    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
    await context.SignInAsync(claimsPrincipal);
    return $"Установлено имя {username}";
});
app.Map("/", (HttpContext context) =>
{
    var user = context.User.Identity;
    if (user is not null && user.IsAuthenticated)
        return $"UserName: {user.Name}";
    else return "Пользователь не аутентифицирован.";
});
app.MapGet("/logout", async (HttpContext context) =>
{
    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return "Данные удалены";
});
*/


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});

/*
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    if (app.Environment.IsDevelopment())
    {
        spa.UseAngularCliServer(npmScript: "start");
    }
});

*/

app.Run();

