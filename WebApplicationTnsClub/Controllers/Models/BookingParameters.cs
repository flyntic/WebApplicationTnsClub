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

namespace WebApplicationTnsClub.Controllers.Models
{

    public class BookingParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public UserParameters?[] Users { get; set; }

        public ClubParameters? Club { get; set; }

        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public string? Length { get; set; }
        public StateBooking? StateBooking { get; set; }
        public PriceParameters? Price { get; set; }
        //public int? Price { get; set; }
        public BookingParameters? Next { get; set; }

        public DateTime? DateOfSale { get; set; }

        public UserParameters? UserOfSale { get; set; }
        public string? Comment { get; set; }

        public BookingParameters FromBooking(Booking booking)
        {
            BookingParameters parameters = new BookingParameters()
            {
                Id = booking.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
                Date = booking.Date,
                Time = booking.Time,
                Length = booking.Length,
                StateBooking = booking.StateBooking,
        //        Price = new PriceParameters().FromPrices(booking.Price), //Next=booking.Next,
                DateOfSale = booking.DateOfSale
                
            };

            return parameters;
        }
        public Booking toBaseId()
        {
            Booking booking = new Booking()
            {
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
                Date = this.Date,
                Time = this.Time,
                Length = this.Length,
                StateBooking = this.StateBooking,
               // Price = this.Price.ToPrices(), //Next=booking.Next,
                DateOfSale = this.DateOfSale
            };

            return booking;
        }
    }
}
