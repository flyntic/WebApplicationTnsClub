using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

    public class ApiUser : ApiBaseId
    {
        //public string? Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public string? AvatarFile { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? Comment { get; set; }

        public static ApiUser fromBaseId(User user)
        {
           // User user = item as User;

            ApiUser apiItem = new ApiUser()
            {
               // Id = user.Id,
                Login = user.Login,
                UserName=user.UserName,
               // Password=user.PasswordHash,
                AvatarFile = user.AvatarFile,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                LastName = user.LastName,
                Comment = user.Comment
            };
            return apiItem;
        }

        public User toBaseId()
        {   
            User s = new User() {
            Id =this.Id   ,
            Login =this.Login, 
            UserName=this.UserName,
            AvatarFile=this.AvatarFile,
            FirstName =this.FirstName ,
            SecondName =this.SecondName, 
            LastName= this.LastName ,
            Comment =this.Comment 

            };
            return s;
        }

       
    }
}
