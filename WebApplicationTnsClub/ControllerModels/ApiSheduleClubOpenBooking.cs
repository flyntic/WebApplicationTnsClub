using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiSheduleClubOpenBooking : ApiBaseId
    {
        public long Id { get; set; }
        public ApiSheduleClub? SheduleClub { get; set; }
        public DateTime? Date { get; set; }
        public StateBooking? StateBooking { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            SheduleClubOpenBooking sheduleClubOpenBooking = item as SheduleClubOpenBooking;

            IApiBaseId apiItem = new ApiSheduleClubOpenBooking()
            {
                Id = sheduleClubOpenBooking.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return apiItem;
        }
        public BaseId toBaseId()
        {
            SheduleClubOpenBooking s = new SheduleClubOpenBooking() { };
            return s;
        }
    }
}
