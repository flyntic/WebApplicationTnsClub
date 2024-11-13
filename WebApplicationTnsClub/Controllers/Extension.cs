using WebApplicationTnsClub.ControllerModels;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers
{  
    public static class Extension
    {
        public static T toNew<T,ApiT>(this ApiT apiItem) where T:BaseId where ApiT : IBaseId
        {

          //  T item = new ApiT();
            {
               // BaseId = id,
                //FirstName = apiuser.FirstName,
              //  LastName = apiuser.LastName,
              //  AvatarFile = apiuser.AvatarFile

            };
            return item;
        }

        public static ApiBooking toApiBooking(this Booking booking)
        {

            ApiBooking apibooking = new ApiBooking
            {
            // .. = user.LastName,
            //    AvatarFile = user.AvatarFile


            };
            return apibooking;
        }
    }
}
