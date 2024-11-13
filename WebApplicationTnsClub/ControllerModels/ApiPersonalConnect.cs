using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiPersonalConnect : IApiBaseId
    {
        public long Id { get; set; }
        public ApiUser? Mentor { get; set; }

        public ApiUser? Heir { get; set; }

        public TypeConnect? TypeConnect { get; set; }

    }
}
