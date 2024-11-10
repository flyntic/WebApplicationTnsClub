using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTnsClub.Models
{
    [Table("Rates")]
    public class Rate //?: IdentityUser
    {

        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("comment")]
        public string? Comment { get; set; }


    }
}
