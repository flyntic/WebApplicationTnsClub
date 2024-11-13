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
    public class User : IdentityUser
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(@"datecreate")]
        public DateTime DateCreate { get; set; }

        [Column(@"dateupdate")]
        public DateTime DateUpdate { get; set; }=DateTime.Now;

        [Column(@"isdeleted")]
        public bool IsDeleted { get; set; }

        [Column(@"datedelete")]
        public DateTime DateDelete { get; set; }

        [Column("avatarfile")]
        public string? AvatarFile {  get; set; }
//        [Column("name")]
//        public string? Name { get; set; }
        [Column("firstname")]
        public string? FirstName { get; set; }
        [Column("secondname")]
        public string? SecondName { get; set; }
        [Column("lastname")]
        public string? LastName { get; set; }
        [Column("login")]
        public string?  Login { get; set; }
      //  [Column("phone")]
      //  public string? Phone { get; set; }
  //      [Column("email")]
 //       public string? Email { get; set; }
 //       [Column("role")]
  //      public int?    Role { get; set; }
//        [Column("parole")]
//        public string? Parole { get; set; }
        [Column("comment")]
        public string? Comment { get; set; }

   //     public DateTime DateCreate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   //     public DateTime DateUpdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   //     public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   //     int IBaseId.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
