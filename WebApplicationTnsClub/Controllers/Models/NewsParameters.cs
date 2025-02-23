using WebApplicationTnsClub.Models.AboutClub;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class NewsParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public string? Text { get; set; }

        public string? Link { get; set; }

        public string? ImageFile { get; set; }

        public ClubParameters? Club { get; set; }

        public UserParameters? Author { get; set; }

        public static NewsParameters FromNews(News news)
        {
        

            NewsParameters parameters = new NewsParameters()
            {
                Id = news.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return parameters;
        }
        public News ToNews(News news)
        {
          //  News news = new News()
            {
                Id = news.Id;
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
