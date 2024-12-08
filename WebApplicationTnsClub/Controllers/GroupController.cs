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
    [Route("api/groups")]
    public class GroupController : Controller
    {
        ApplicationContext db;
        public GroupController(ApplicationContext context)
        {
            db = context;
            if (!db.Groups.Any())
            {
                //  db.Users.Add(new User { name = "iPhone X", last_name = "Apple", login = "79900" });
                //  db.Users.Add(new User { name = "Galaxy S8", last_name = "Samsung", login = "49900 "});
                //  db.Users.Add(new User { name = "Pixel 2", last_name = "Google", login = "52900" });
                //  db.SaveChanges();
            }
        }
    /*    [HttpGet]
        public async Task<IEnumerable<ApiGroup>> Get()
        {
           List<ApiGroup> apiGroups = new List<ApiGroup>();
           try
            {
                List<Group> groups = await db.Groups.ToListAsync();
                foreach (var group in groups)
                {
                    apiGroups.Add(group.toApi());
                    
                }
                return apiGroups;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    
        [HttpGet("{id}")]
        public async Task<ApiGroup> Get(long id)
        {
                Group group = await db.Groups.FirstOrDefaultAsync(x => x.Id == id);
                    
            return group.toApi();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ApiGroup group)
        {
            if (ModelState.IsValid)
            {
              //  Console.WriteLine("add user" + user.ToString());
                await db.Groups.AddAsync(user);//.toNewUser()
              //  Console.WriteLine("add");
                db.SaveChanges();
              //  Console.WriteLine("end add");

         */     /*  if (user.Avatarfile!=null)
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
        /*        
                return Ok(group);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ApiGroup group)
        {
            if (ModelState.IsValid)
            {
              //todo  db.Update(user.toUser());
                await db.SaveChangesAsync();
                return Ok(group);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            Group group = await db.Groups.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (group != null)
            {
                group.IsDeleted = true;
               // db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(group);
        }*/
    }
}
