using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApplicationTnsClub.Controllers;
using WebApplicationTnsClub.DB;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/sheduleclubopenbookings")]
    public class SheduleClubOpenBookingController : Controller
    {
        ApplicationContext db;
        public SheduleClubOpenBookingController(ApplicationContext context)
        {
            db = context;
            
        }
        /*
        [HttpGet]
        public async Task<IEnumerable<ApiUser>> Get()
        {
           List<ApiUser> apiUsers = new List<ApiUser>();
           try
            {
                List<User> users = await db.Users.ToListAsync();
                foreach (var user in users)
                {
                    apiUsers.Add(user.toApiUser());
                    
                }
                return apiUsers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    
        [HttpGet("{id}")]
        public async Task<ApiUser> Get(long id)
        {
                User user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
                    
            return user.toApiUser();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ApiUser user)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("add user" + user.ToString());
                await db.Users.AddAsync(user);//.toNewUser()
                Console.WriteLine("add");
                db.SaveChanges();
                Console.WriteLine("end add");
        */
              /*  if (user.Avatarfile!=null)
                {   string bdfilename = "c://wwwroot/uploads/save" + user.Id + ".jpg";
                    try
                    {  // System.IO.File.Copy(user.Avatarfile, bdfilename);
                      //  System.IO.File.Delete(user.Avatarfile);                       
                        user.Avatarfile = bdfilename;
                        db.Users.Update(user);
                        db.SaveChanges();                        
                    }
                    catch (Exception ex) { 
                      Console.WriteLine(ex.Message);
                    }

                } */
                
        /*        return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ApiUser user)
        {
            if (ModelState.IsValid)
            {
              //todo  db.Update(user.toUser());
                await db.SaveChangesAsync();
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (user != null)
            {
                user.IsDeleted = true;
               // db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(user);
        }*/
    }
}
