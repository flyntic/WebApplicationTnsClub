using WebApplicationTnsClub.ControllerModels;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers
{  
    public static class ExtensionBooking
    {
        public static Booking toNewBooking(this ApiBooking apibooking)
        {
            BaseId id = new BaseId { DateCreate = DateTime.Now };
            Booking booking = new Booking
            {
               // BaseId = id,
                //FirstName = apiuser.FirstName,
              //  LastName = apiuser.LastName,
              //  AvatarFile = apiuser.AvatarFile

            };
            return booking;
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
