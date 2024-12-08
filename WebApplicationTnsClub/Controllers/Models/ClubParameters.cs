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
    public class ClubParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public string? Logofile { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Link { get; set; }

        public ClubParameters FromClub(Club club)
        {
            ClubParameters parameters = new ClubParameters()
            {
                Id = club.Id,
                Logofile = club.Logofile,
                Name = club.Name,
                Address = club.Address,
                Phone = club.Phone,
                Link = club.Link
            };
            return parameters;
        }
        public Club ToClub()
        {
        
            Club club = new Club()
            {
                Id = this.Id,               
                Logofile = this.Logofile,
                Name = this.Name,
                Address = this.Address,
                Phone = this.Phone,
                Link = this.Link
            };

            return club;
        }
    }
}
