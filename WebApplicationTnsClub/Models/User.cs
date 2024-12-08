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
    [Table("Users")]
    public class User : IdentityUser//, IBaseDataType<long>
    {
      //  [Column("id")]
      //  [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // override public long Id { get; set; } //= Guid.NewGuid();

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
        //============================================================
       // [Column("login")]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      //  public string?  Login { get; set; }
 
        [Column("avatarfile")]
        public string? AvatarFile {  get; set; }
        [Column("firstname")]
        public string? FirstName { get; set; }
        [Column("secondname")]
        public string? SecondName { get; set; }
        [Column("lastname")]
        public string? LastName { get; set; }
 

        ///public User():base()
       // {
            
        //}

     }
}
