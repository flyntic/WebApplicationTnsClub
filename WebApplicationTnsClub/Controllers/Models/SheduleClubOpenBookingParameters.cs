using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class SheduleClubOpenBookingParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public SheduleClubParameters? SheduleClub { get; set; }
        public DateTime? Date { get; set; }
        public StateBooking? StateBooking { get; set; }

        public static SheduleClubOpenBookingParameters FromSheduleClubOpenBooking(SheduleClubOpenBooking item)
        {


            SheduleClubOpenBookingParameters apiItem = new SheduleClubOpenBookingParameters()
            {
                Id = item.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return apiItem;
        }
        public SheduleClubOpenBooking ToSheduleClubOpenBooking(SheduleClubOpenBooking s)
        {
            
            return s;
        }
    }
}
