using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{

    public class ApiRate : ApiBaseId //?: IdentityUser
    {
        public long Id { get; set; }
        public ApiClub? Club { get; set; }

        public string? Name { get; set; }

        public ApiShedule?[] Shedules { get; set; }

        public int? Price { get; set; }

        public string? Comment { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            Rate rate = item as Rate;

            IApiBaseId apiItem = new ApiRate()
            {
                Id = rate.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return apiItem;
        }
        public BaseId toBaseId()
        { Rate rate = new Rate() { };
            return rate;
        }
    }
}
