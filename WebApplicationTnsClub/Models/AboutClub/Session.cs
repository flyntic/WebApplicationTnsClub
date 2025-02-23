using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models.AboutClub
{
    public enum TypeOfDay
    {
        Default,
        Holiday,
        WeekendDay
    }
    [Table(@"Sessions")]
    public class Session : IBaseDataType<long>
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
        //=====================================================
        [Column("typeofday")]
        public TypeOfDay? TypeOfDay { get; set; }

        [Column("time")]
        public string? Time { get; set; }

        [Column("length")]
        public int? Length { get; set; }


    }
}
