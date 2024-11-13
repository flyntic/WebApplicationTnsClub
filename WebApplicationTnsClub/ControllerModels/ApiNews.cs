using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiNews : IApiBaseId
    {
        public int Id { get; set; }
        public string? Text { get; set; }

        public string? Link { get; set; }

        public string? ImageFile { get; set; }

        public ApiClub? Club { get; set; }

        public ApiUser? Author { get; set; }

    }
}
