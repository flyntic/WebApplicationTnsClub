using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiGroup : ApiBaseId
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        public ApiUser? Organizator { get; set; }

        public ApiClub? Club { get; set; }
        public ApiShedule?[] Shedules { get; set; }

        public ApiRate?[] Rates { get; set; }

        public ApiUser?[] Players { get; set; }
        public string? State { get; set; }
        public string? Comment { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            Group group = item as Group;

            IApiBaseId apiItem = new ApiGroup()
            {
                Id = group.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                Comment = group.Comment
            };

            return apiItem;
        }

        public BaseId toBaseId()
        {
            Group group = new Group()
            {
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
           //     Date = this.Date,
           //     Time = this.Time,
            //    Length = this.Length,
            //    StateBooking = this.StateBooking,
            //    Price = this.Price, //Next=booking.Next,
            //    DateOfSale = this.DateOfSale,
                Comment = this.Comment
            };

            return group;
        }
    }
}
