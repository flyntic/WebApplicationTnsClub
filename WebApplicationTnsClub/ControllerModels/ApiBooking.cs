using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;
using WebApplicationTnsClub.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplicationTnsClub.ControllerModels
{
    
    public class ApiBooking: ApiBaseId
    {
        public long Id { get; set; }
        public ApiUser?[] Users { get; set; }

        public ApiClub? Club { get; set; }

        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public string? Length { get; set; }
        public StateBooking? StateBooking { get; set; }
        public ApiRate? Rate { get; set; }
        public int? Price { get; set; }
        public ApiBooking? Next { get; set; }

        public DateTime? DateOfSale { get; set; }

        public ApiUser? UserOfSale { get; set; }
        public string? Comment { get; set; }

        public ApiBaseId FromBaseId(BaseId item)
        {   
            Booking booking=item as Booking;

            ApiBaseId apiItem=new ApiBooking() {
             Id=booking.Id,
             //ApiUser?[] Users { get; set; }
              //ApiClub? Club { get; set; }
             //ApiRate? Rate { get; set; }
            //public ApiUser? UserOfSale { get; set; }
             Date=booking.Date,
             Time=booking.Time, Length=booking.Length,
             StateBooking=booking.StateBooking,
             Price=booking.Price, //Next=booking.Next,
             DateOfSale=booking.DateOfSale,
             Comment=booking.Comment
             };

            return apiItem;
        }
        public BaseId toBaseId()
        {
            Booking booking = new Booking() { 
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
                Date = this.Date,
                Time = this.Time,
                Length = this.Length,
                StateBooking = this.StateBooking,
                Price =     this.Price, //Next=booking.Next,
                DateOfSale = this.DateOfSale,
                Comment = this.Comment
            };

            return booking;
        }
    }
}
