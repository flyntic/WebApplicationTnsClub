using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiGroup : IApiBaseId
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
    }
}
