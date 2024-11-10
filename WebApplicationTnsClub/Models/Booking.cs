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
    [Table("Bookings")]
    public class Booking 
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long  Id { get; set; }

        [Column("user_id")]
         public long? UserId { get; set; }
      
      //  [ForeignKey("UserId")]
      //  public User? User { get; set; }

        [Column("club_id")]
        public long? ClubId { get; set; }
   //     [ForeignKey("ClubId")]
   //     public Club?  Club { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
        [Column("time")]
        public string? Time { get; set; }
        [Column("length")]
        public string?  Length { get; set; }

        [Column("rate_id")]
        public int? RateId { get; set; }
  //      [ForeignKey("RateId")]
  //      public Rate? Rate { get; set; }
        [Column("price")]
        public int? Price { get; set; }

        [Column("date_of_booking")]
        public DateTime? DateOfBooking { get; set; }
        [Column("user_of_booking_id")]
        public long? UserOfBookingId { get; set; }
    //    [ForeignKey("UserOfBookingId")]
    //    public User? UserOfBooking { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("comment")]
        public string? Comment { get; set; }
 
       
    }
}
