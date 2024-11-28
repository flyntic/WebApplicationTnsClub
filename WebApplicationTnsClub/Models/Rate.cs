using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTnsClub.Models
{
    [Table(@"Rates")]
    public class Rate :BaseId //?: IdentityUser
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Column(@"datecreate")]
        public DateTime DateCreate { get; set; }

        [Column(@"dateupdate")]
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        [Column(@"isdeleted")]
        public bool IsDeleted { get; set; }

        [Column(@"datedelete")]
        public DateTime? DateDelete { get; set; }

        //====================================================
        [Column("club")]
        public Club? Club { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("shedules")]
        public Shedule?[] Shedules { get; set; }

        [Column("price")]
        public int? Price { get; set; }
        
        [Column("comment")]
        public string? Comment { get; set; }
         }
}
