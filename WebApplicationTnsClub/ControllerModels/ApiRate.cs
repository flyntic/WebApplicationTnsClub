using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTnsClub.ControllerModels
{

    public class ApiRate : IApiBaseId //?: IdentityUser
    {
        public long Id { get; set; }
        public ApiClub? Club { get; set; }

        public string? Name { get; set; }

        public ApiShedule?[] Shedules { get; set; }

        public int? Price { get; set; }

        public string? Comment { get; set; }


    }
}
