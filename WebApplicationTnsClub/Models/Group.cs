using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table(@"Groups")]
    public class Group
    {
        //==============================  BaseId =====================

        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(@"datecreate")]
        public DateTime DateCreate { get; set; }

        [Column(@"dateupdate")]
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        [Column(@"isdeleted")]
        public bool IsDeleted { get; set; }

        [Column(@"datedelete")]
        public DateTime? DateDelete { get; set; }

        //=========================================================
        [Column(@"name")]
        public string? Name { get; set; }

        [Column(@"organizator")]
        public User? Organizator { get; set; }

        [Column(@"club")]
        public Club? Club { get; set; }

        [Column(@"shedule")]
        public Shedule?[] Shedules { get; set; }

        [Column(@"rates")]
        public Rate?[] Rates { get; set; }

        [Column(@"players")]
        public User?[] Players { get; set; }

        [Column(@"state")]
        public string? State { get; set; }

        [Column(@"comment")]
        public string? Comment { get; set; }
        

    }
}
