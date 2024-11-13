using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplicationTnsClub.Models
{
    [Table("Clubs")] 
    public class Club  :IBaseId //?: IdentityUser
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
        public DateTime DateDelete { get; set; }

        [Column("logofile")]
        public string? Logofile {  get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("address")]
        public string? Address { get; set; }
        [Column("phone")]
        public string? Phone { get; set; }
        [Column("comment")]
        public string? Comment { get; set; }
    }
}
