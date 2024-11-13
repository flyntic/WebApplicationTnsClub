using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table(@"News")]
    public class News:IBaseId
    {
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

        //==========================================
        [Column(@"text")]
        public string? Text { get; set; }

        [Column(@"link")]
        public string? Link { get; set; }

        [Column(@"imagefile")]
        public string? ImageFile { get; set; }

        //ForeignKey
        [Column(@"club")]
        public Club? Club { get; set; }

        //ForeignKey
        [Column(@"author") ]
        public User? Author { get; set; }


    }
}
