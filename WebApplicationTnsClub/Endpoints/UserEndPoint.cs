using Azure.Identity;
using System;
using System.Linq;
using System.Security.Claims;


namespace WebApplicationTnsClub.Endpoints
{
    public class UserEndPoint
    {
        private static Dictionary<string,string> userObj =new Dictionary<string, string>() { { "user_id", " 1" }, { "username", "Anna" } };
        public static Dictionary<string, string> Handler(HttpContext context)//(ClaimsPrincipal user)=>//
              {
            Console.WriteLine("call user");
            //return userObj;
                return context.User.Claims.ToDictionary(x => x.Type, x => x.Value);
              }//.FindAll("user_id").
     
        
    }
}
