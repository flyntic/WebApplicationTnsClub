using WebApplicationTnsClub.ControllerModels;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers
{  
    public static class Extension
    {
 /*       public static void toNew<ApiT,T>(this ApiT apiItem,T item) where T:BaseId where ApiT : ApiBaseId
        {
           // BaseId obj = null;
            if (apiItem.GetType().Equals(typeof( ApiBooking)))
            {
                ApiUser ApiItem = apiItem as ApiUser;
                item = new Booking()
                {
                 //   FirstName = ApiItem.FirstName,
                  //  LastName = ApiItem.LastName,
                 //   AvatarFile = ApiItem.AvatarFile,
                 //   Login = ApiItem.Login,
                 //   Comment = ApiItem.Comment
                };
               // item = user;
            }
           // ApiT item = new ApiT();
           // {
               // BaseId = id,
                //FirstName = apiuser.FirstName,
              //  LastName = apiuser.LastName,
              //  AvatarFile = apiuser.AvatarFile

           // };
          //  return (T)obj;
        }*/
        public static void toNew<ApiT>(this ApiT apiItem, User item)  where ApiT : ApiBaseId
        {
            // BaseId obj = null;
            if (apiItem.GetType().Equals(typeof(ApiUser)))
            {
                ApiUser ApiItem = apiItem as ApiUser;
                User user = new User()
                {
                    FirstName = ApiItem.FirstName,
                    LastName = ApiItem.LastName,
                    AvatarFile = ApiItem.AvatarFile,
                    Login = ApiItem.Login,
                    Comment = ApiItem.Comment
                };
                item = user;
            }
            // ApiT item = new ApiT();
            // {
            // BaseId = id,
            //FirstName = apiuser.FirstName,
            //  LastName = apiuser.LastName,
            //  AvatarFile = apiuser.AvatarFile

            // };
            //  return (T)obj;
        }

        public static ApiT toApi<ApiT,T>(this T item) where ApiT:ApiBaseId where T:BaseId
        {
            ApiBaseId obj = null;
            if (item.GetType().Equals(new User()))
                {
                  User Item=item as User;
                  obj = new ApiUser() {FirstName=Item.FirstName,LastName=Item.LastName,
                                       AvatarFile=Item.AvatarFile,Login=Item.Login,
                                       Comment=Item.Comment};
                }

            if (item.GetType().Equals(new Booking()))
            {
                Booking Item=item as Booking;
                obj = new ApiBooking() {};
            }


         //   Api apiItem = new ApiUser();
          //  apiItem.Id = item.Id;
          //  {
            // .. = user.LastName,
            //    AvatarFile = user.AvatarFile


           // };
            return (ApiT)obj;
        }
    }
}
