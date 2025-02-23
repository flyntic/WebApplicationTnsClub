using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Models.AboutClub
{
    [Table(@"Groups")]
    public class Group : IBaseDataType<long>
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

        [Column("coach")]
        public Coach? Coach { get; set; }

        [Column("sessions")]
        public Session?[] Sessions { get; set; }

        [Column("players")]
        public User?[] Players { get; set; }

        [Column("state")]
        public string? State { get; set; }



    }
}
