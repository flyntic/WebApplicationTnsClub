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

namespace WebApplicationTnsClub.ControllerModels
{
    
    public class ApiBooking 
    {
      
        public long  Id { get; set; }
        public long? UserId { get; set; }     
        public long? ClubId { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public string?  Length { get; set; }
        public int? RateId { get; set; }
        public int? Price { get; set; }
        public DateTime? DateOfBooking { get; set; }
        public long? UserOfBookingId { get; set; }
        public string? State { get; set; }
        public string? Comment { get; set; }
 
       
    }
}
