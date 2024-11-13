using WebApplicationTnsClub.ControllerModels;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers
{
    public static class ExtensionUser
    {
        public static User toNew(this ApiUser apiuser)
        {
            BaseId id = new BaseId { DateCreate = DateTime.Now };
            User user = new User
            {
                //Id = id,

                FirstName = apiuser.FirstName,
                LastName = apiuser.LastName,
                AvatarFile = apiuser.AvatarFile

            };
            return user;
        }

        public static ApiUser toApi(this User user)
        {

            ApiUser apiuser = new ApiUser
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                AvatarFile = user.AvatarFile


            };
            return apiuser;
        }
    }
}
