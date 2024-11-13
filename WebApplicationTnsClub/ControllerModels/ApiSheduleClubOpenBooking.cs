using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiSheduleClubOpenBooking : IApiBaseId
    {
        public long Id { get; set; }
        public ApiSheduleClub? SheduleClub { get; set; }
        public DateTime? Date { get; set; }
        public ApiStateBooking? StateBooking { get; set; }

    }
}
