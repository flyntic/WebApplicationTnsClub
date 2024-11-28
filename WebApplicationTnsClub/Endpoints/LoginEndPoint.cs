using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using TinifyAPI;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Endpoints
{
    public class LoginEndPoint
    {
        public class LoginForm
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public static async Task<IResult> Handler(
              LoginForm form,
             // HttpContext context,
              SignInManager<IdentityUser> signInManager)
        {
            var result = await signInManager.PasswordSignInAsync(form.Username, form.Password, true, false);
            if (result.Succeeded)
            {
                return Results.Ok();
            }

            return Results.BadRequest();
        }
            /*=>
        await context.SignInAsync(
            new ClaimsPrincipal(
               new ClaimsIdentity(
                  new Claim[] {
                    new Claim("user_id", Guid.NewGuid().ToString()),//ClaimTypes.SerialNumber
                    new Claim("username", form.Username)//ClaimTypes.Name
                   }, "cookie"
               )
            ));*/
         }
    
}
