using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models.AboutClub
{
    [Table("GroupClubs")]
    public class GroupClub : IBaseDataType<long>
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
        //======================================================
        [Column("club")]
        public Club? Club { get; set; }

        [Column("group")]
        public Group? Group { get; set; }
 
        [Column("name")]
        public string? Name { get; set; }

        [Column("price")]
        public int? Price { get; set; }


    }
}
