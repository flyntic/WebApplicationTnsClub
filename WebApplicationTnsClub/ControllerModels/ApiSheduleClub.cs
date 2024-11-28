using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiSheduleClub : ApiBaseId
    {
        public long Id { get; set; }
        public Club? Club { get; set; }
        public Shedule?[] Shedules { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            SheduleClub sheduleClub = item as SheduleClub;

            IApiBaseId apiItem = new ApiSheduleClub()
            {
                Id = sheduleClub.Id,
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
            SheduleClub s = new SheduleClub() { };
            return s;
        }
    }
}
