using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiNews : ApiBaseId
    {
        public long Id { get; set; }
        public string? Text { get; set; }

        public string? Link { get; set; }

        public string? ImageFile { get; set; }

        public ApiClub? Club { get; set; }

        public ApiUser? Author { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            News news = item as News;

            IApiBaseId apiItem = new ApiNews()
            {
                Id = news.Id,
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
            News news = new News()
            {
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
         //       Date = this.Date,
        // /       Time = this.Time,
           //     Length = this.Length,
          //      StateBooking = this.StateBooking,
            //    Price = this.Price, //Next=booking.Next,
            //    DateOfSale = this.DateOfSale,
            //    Comment = this.Comment
            };

            return news;
        }
    }
}
