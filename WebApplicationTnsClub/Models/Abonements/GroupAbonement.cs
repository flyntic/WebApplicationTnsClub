using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationTnsClub.Models.AboutClub;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Models.Abonements
{
    [Table("GroupAbonements")]
    public class GroupAbonement : IBaseDataType<long>
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

        [Column("groupclub")]
        public GroupClub? GroupClub { get; set; }

        [Column("datebegin")]
        public DateTime DateBegin { get; set; }

        [Column("dateend")]
        public DateTime DateEnd { get; set; }

        [Column("lengthdays")]
        public int LengthDays { get; set; }

        [Column("lengthstr")]
        public string LengthStr { get; set; }

        [Column("countofsession")]
        public int? Count { get; set; }

        [Column("price")]
        public int? Price { get; set; }


    }
}
