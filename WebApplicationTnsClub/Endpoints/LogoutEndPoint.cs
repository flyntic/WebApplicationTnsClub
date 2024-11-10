using Microsoft.AspNetCore.Identity;

namespace WebApplicationTnsClub.Endpoints
{
    public class LogoutEndPoint
    {
        public static async Task<IResult> Handler(SignInManager<IdentityUser> signInManager)
        {
            await signInManager.SignOutAsync();
            return Results.Ok();//SignOut(authenticationSchemes: new List<string>() { "cookie" });
        }
    }
}
