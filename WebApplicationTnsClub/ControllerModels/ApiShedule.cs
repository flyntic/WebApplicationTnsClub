using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiShedule : ApiBaseId
    {
        public long Id { get; set; }    
        public TypeOfDay? TypeOfDay { get; set; }

        public string? Time { get; set; }
        public int? Length { get; set; }

        public string? Comment { get; set; }
        public IApiBaseId ApiBaseId(IBaseId item)
        {
            Shedule shedule = item as Shedule;

            IApiBaseId apiItem = new ApiShedule()
            {
                Id = shedule.Id,
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
            Shedule shedule = new Shedule() { };
            return shedule;
        }
    }
}
