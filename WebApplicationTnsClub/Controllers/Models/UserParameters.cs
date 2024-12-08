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

namespace WebApplicationTnsClub.Controllers.Models
{

    public class UserParameters : IBaseParameters<string>
    {
        public string? Id { get; set; }
    //    public string? Login { get; set; }
    //    public string? Password { get; set; }

        public string? AvatarFile { get; set; }
    //    public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }

        public static UserParameters FromUser(User user)
        {
            UserParameters parameters = new UserParameters()
            {
                 Id = user.Id,
    //            Login = user.Login,
     //           UserName = user.UserName,
                // Password=user.PasswordHash,
                AvatarFile = user.AvatarFile,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                LastName = user.LastName,
            };
            return parameters;
        }

        public User ToUser(User user)
        {
          //  User s = new User()
          
            {
                //user.Id = this.Id;
                //        Login = Login,
                //        UserName = this.UserName,
                user.AvatarFile = this.AvatarFile;
                user.FirstName = this.FirstName;
                user.SecondName = this.SecondName;
                user.LastName = this.LastName;

            };
            return user;
        }


    }
}
