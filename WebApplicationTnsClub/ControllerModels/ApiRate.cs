using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTnsClub.ControllerModels
{

    public class ApiRate //?: IdentityUser
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Comment { get; set; }


    }
}
