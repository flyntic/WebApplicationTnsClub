using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.Controllers;
using WebApplicationTnsClub.Controllers.Models;
using WebApplicationTnsClub.DB;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        ApplicationContext db;
        public UserController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<IEnumerable<UserParameters>> Get() 
        {
            List<UserParameters> usersParameters = new List<UserParameters>();
            try
            {

                List<User> users = await db.Set<User>().ToListAsync();
                foreach (User item in users)
                {
                    usersParameters.Add(UserParameters.FromUser(item));

                }
                return usersParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
        [HttpGet("{id}")]
        public async Task<UserParameters> Get (string id) 
        {
                User user = await db.Set<User>().FirstOrDefaultAsync(x => x.Id.Equals(id));
                UserParameters userParameters = UserParameters.FromUser(user);
                    
            return userParameters;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserParameters userParameters)
        {
            if (ModelState.IsValid)
            { User user=new User();
                try {
                 //   user = ;
                userParameters.ToUser(user);
                await db.Users.AddAsync(user);//.toNewUser()

                db.SaveChanges();
                }
             //   Console.WriteLine("end add");

              /*  if (user.Avatarfile!=null)
                {   string bdfilename = "c://wwwroot/uploads/save" + user.Id + ".jpg";
                    try
                    {  // System.IO.File.Copy(user.Avatarfile, bdfilename);
                      //  System.IO.File.Delete(user.Avatarfile);                       
                        user.Avatarfile = bdfilename;
                        db.Users.Update(user);
                        db.SaveChanges();                        
                    }} */
                    catch (Exception ex) { 
                      Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                   }

                
                
               return Ok(userParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserParameters userParameters)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Where(user =>  user.Id == userParameters.Id).First();



                user=userParameters.ToUser(user);
                try
               {
                   db.Update(user);
                   await db.SaveChangesAsync();
                    return Ok(userParameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            Console.WriteLine(id);
            User user = await db.Users.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (user != null)
            {
                user.IsDeleted = true;
                db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(user);
        }
    }
}
