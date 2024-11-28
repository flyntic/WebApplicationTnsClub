using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiTicket : ApiBaseId
    {
        public long Id { get; set; }
        public ApiBooking?[] Bookings { get; set; }
        public ApiShedule?[] Shedules { get; set; }
        public int? Price { get; set; }
        public bool? isAutorenewal { get; set; }
        public string? State { get; set; }
        public string? Comment { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            Ticket ticket = item as Ticket;

            IApiBaseId apiItem = new ApiSheduleClubOpenBooking()
            {
                Id = ticket.Id,
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
            Ticket s = new Ticket() { };
            return s;
        }
    }
}
