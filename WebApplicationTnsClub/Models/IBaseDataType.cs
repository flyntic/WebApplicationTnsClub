using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    public interface IBaseDataType<T>
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public T Id { get; set; }

        [Column("datecreate")]
        public DateTime DateCreate { get; set; }

        [Column("dateupdate")]
        public DateTime DateUpdate { get; set; } 

        [Column("isdeleted")]
        public bool IsDeleted { get; set; }

        [Column("datedelete")]
        public DateTime? DateDelete { get; set; }

        [Column("comment")]
        public string? Comment { get; set; }
    }


}
