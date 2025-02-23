using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;
using WebApplicationTnsClub.Models.AboutClub;
using WebApplicationTnsClub.Models.Users;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplicationTnsClub.Models.Bookings
{
    public enum StateBooking
    {
        Reserv,
        Confirm,
        Cancel,
        Skipped,
        Transfer,
        CloseForSale
    }

    [Table("Bookings")]
    public class Booking : IBaseDataType<long>
    {
        [Column(@"id", TypeName = "bigint")]
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

        [Column("user")]
        public User? User { get; set; }

        [Column("club")]
        public Club? Club { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
        [Column("time")]
        public string? Time { get; set; }
        [Column("length")]
        public string? Length { get; set; }

        [Column("state")]
        public StateBooking? StateBooking { get; set; }

        [Column("price")]
        public int? Price { get; set; }

        [Column("visit")]
        public DateTime? Visit { get; set; }

/*        [Column("date_of_sale")]
        public DateTime? DateOfSale { get; set; }

        [Column("user_of_sale")]
        public User? UserOfSale { get; set; }
*/
    }
}
