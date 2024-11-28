using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table("SheduleClubs")]
    public class SheduleClub:BaseId
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

        //======================================================
        [Column(@"club")]
        public Club? Club { get; set; }

        [Column(@"shedule")]
        public Shedule?[] Shedules { get; set; }



    }
}
