using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public class ApiSheduleClub : IApiBaseId
    {
        public long Id { get; set; }
        public Club? Club { get; set; }
        public Shedule?[] Shedules { get; set; }


    }
}
