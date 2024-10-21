using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;

namespace WebApplicationTnsClub.Models
{
    [Table("Users")]
    public class User
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("avatar", TypeName = "blob")]
        public Blob? avatar { get; set; }
        public String? avatarfile {  get; set; }
        public String name { get; set; }
        public String? second_name { get; set; }
        public String? last_name { get; set; }
        public String login { get; set; }
        public String? phone { get; set; }
        public String? email { get; set; }
        public int? role { get; set; }
        public String? parole { get; set; }
        public String? comment { get; set; }
    }
}
