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
    public class ApiClub : ApiBaseId  //?: IdentityUser
    {
        public long Id { get; set; }
        public string? Logofile { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Link { get; set; }

        public string? Comment { get; set; }

        public IApiBaseId ApiBaseId(IBaseId item)
        {
            Club club = item as Club;

            IApiBaseId apiItem = new ApiClub()
            {
                Id = club.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
                
                Comment = club.Comment
            };

            return apiItem;
        }
        public BaseId toBaseId()
        {
            Club club = new Club()
            {
                Id = this.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
            //    Date = this.Date,
            //    Time = this.Time,
             //   Length = this.Length,
            //    StateBooking = this.StateBooking,
             //   Price = this.Price, //Next=booking.Next,
             //   DateOfSale = this.DateOfSale,
                Comment = this.Comment
            };

            return club;
        }
    }
}
