using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{

    public class PriceParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public ClubParameters? Club { get; set; }

        public string? Name { get; set; }

        public SessionParameters?[] Sessions { get; set; }

        public int? Price { get; set; }

        public string? Comment { get; set; }

        public PriceParameters FromPrices(Prices prices)
        {
            PriceParameters parameters = new PriceParameters()
            {
                Id = prices.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return parameters;
        }
        public Prices ToPrices()
        {
            Prices prices = new Prices() { };
            return prices;
        }
    }
}
