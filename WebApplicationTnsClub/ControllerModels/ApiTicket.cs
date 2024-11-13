using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiTicket : IApiBaseId
    {
        public int Id { get; set; }
        public ApiBooking?[] Bookings { get; set; }
        public ApiShedule?[] Shedules { get; set; }
        public int? Price { get; set; }
        public bool? isAutorenewal { get; set; }
        public string? State { get; set; }
        public string? Comment { get; set; }

    }
}
