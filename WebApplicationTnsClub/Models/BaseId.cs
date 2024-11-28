using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTnsClub.Models
{
    public class BaseId:IBaseId
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

       // public static implicit operator BaseId(User v)
        //{
        //    throw new NotImplementedException();
       // }
    }
}
