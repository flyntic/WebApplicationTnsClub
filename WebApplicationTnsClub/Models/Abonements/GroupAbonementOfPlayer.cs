using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationTnsClub.Models.Abonements;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Models
{
    [Table("GroupAbonementsOfPalyers")]
    public class GroupAbonementOfPlayer:IBaseDataType<long>
    {
        [Column("id", TypeName = "bigint")]
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
     //====================================================

        [Column("abonement")]
        public GroupAbonement? Abonement { get; set; }

        [Column("player")]
        public Player? Player { get; set; }

        [Column("price")]
        public int? Price { get; set; }

        [Column("isautorenewal")]
        public bool? IsAutorenewal { get; set; }

        [Column("visits")]
        public DateTime?[] Visits { get; set; }
    }
}
