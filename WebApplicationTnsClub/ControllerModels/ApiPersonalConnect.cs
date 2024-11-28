using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiPersonalConnect : ApiBaseId
    {
        public long Id { get; set; }
        public ApiUser? Mentor { get; set; }

        public ApiUser? Heir { get; set; }

        public TypeConnect? TypeConnect { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            PersonalConnect personalConnect = item as PersonalConnect;

            IApiBaseId apiItem = new ApiPersonalConnect()
            {
                Id = personalConnect.Id,
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
            PersonalConnect personalConnect = new PersonalConnect()
            {
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
              //  Date = this.Date,
              //  Time = this.Time,
              //  Length = this.Length,
              //  StateBooking = this.StateBooking,
              //  Price = this.Price, //Next=booking.Next,
              //  DateOfSale = this.DateOfSale,
              //  Comment = this.Comment
            };

            return personalConnect;
        }
    }
}
