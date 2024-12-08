using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table(@"Groups")]
    public class Group: IBaseDataType<long>
    {
        //==============================  BaseId =====================

        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Column("datecreate")]
        public DateTime DateCreate { get; set; }

        [Column("dateupdate")]
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        [Column("isdeleted")]
        public bool IsDeleted { get; set; }

        [Column("datedelete")]
        public DateTime? DateDelete { get; set; }

        [Column("comment")]
        public string? Comment { get; set; }
        //=========================================================
        [Column("name")]
        public string? Name { get; set; }

        [Column("organizator")]
        public CoachUser? CoachUser { get; set; }

        [Column("club")]
        public Club? Club { get; set; }

        [Column("shedule")]
        public Session?[] Sessions { get; set; }

        [Column("rates")]
        public Prices?[] Prices { get; set; }

        [Column("players")]
        public User?[] Players { get; set; }

        [Column("state")]
        public string? State { get; set; }

        

    }
}
