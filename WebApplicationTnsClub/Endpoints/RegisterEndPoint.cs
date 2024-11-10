using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Endpoints
{
    public class RegisterEndPoint
    {
        public class RegisterForm
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

        public static async Task<IResult> Handler(
            RegisterForm form,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            if (form.Password != form.ConfirmPassword)
            {
                return Results.BadRequest();
            }

            var user = new IdentityUser() { UserName = form.Username };
            try
            {
                var createUserResult = await userManager.CreateAsync(user, form.Password);
                if (!createUserResult.Succeeded)  return Results.BadRequest(); 
            }

            catch(Exception ex) {
            
                Console.WriteLine(ex.ToString());
            }
            
            await signInManager.SignInAsync(user, true);

            return Results.Ok();
        }
        /*
        public static async Task Handler(LoginForm form, HttpContext context) =>//<IResult>
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
