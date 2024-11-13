using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiShedule : IApiBaseId
    {
        public long Id { get; set; }    
        public TypeOfDay? TypeOfDay { get; set; }

        public string? Time { get; set; }
        public int? Length { get; set; }

        public string? Comment { get; set; }

    }
}
