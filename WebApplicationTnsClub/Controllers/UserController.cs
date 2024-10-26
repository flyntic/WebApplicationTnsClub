using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.Models;

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
            if (!db.Users.Any())
            {
                //  db.Users.Add(new User { name = "iPhone X", last_name = "Apple", login = "79900" });
                //  db.Users.Add(new User { name = "Galaxy S8", last_name = "Samsung", login = "49900 "});
                //  db.Users.Add(new User { name = "Pixel 2", last_name = "Google", login = "52900" });
                //  db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await db.Users.ToListAsync();
        }
    
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            if (ModelState.IsValid)
            {
    
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();

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
                
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(User user)
        {
            if (ModelState.IsValid)
            {
                db.Update(user);
                await db.SaveChangesAsync();
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(user);
        }
    }
}
