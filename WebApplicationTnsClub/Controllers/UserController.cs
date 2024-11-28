using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.ControllerModels;
using WebApplicationTnsClub.Controllers;
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
        public async Task<IEnumerable<ApiUser>> Get() 
        {
            List<ApiUser> apiArray = new List<ApiUser>();
            try
            {

                List<User> array = await db.Set<User>().ToListAsync();
                foreach (User arr in array)
                {
                    apiArray.Add(ApiUser.fromBaseId(arr));

                }
                return apiArray;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
        [HttpGet("{id}")]
        public async Task<ApiUser> Get (string id) 
        {
                User user = await db.Set<User>().FirstOrDefaultAsync(x => x.Id.Equals(id));
                ApiUser apiUser = ApiUser.fromBaseId(user);
                    
            return apiUser;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ApiUser apiUser)
        {
            if (ModelState.IsValid)
            { User user=null;
                try { 
                //   Console.WriteLine("add user" + user.ToString());
               
               
                user=apiUser.toBaseId();
                await db.Users.AddAsync(user);//.toNewUser()
            //    Console.WriteLine("add");
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

                
                
               return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ApiUser apiUser)
        {
            if (ModelState.IsValid)
            {
                //User userFind = db.Users.Find(apiUser.Id);
                User user = apiUser.toBaseId();
                try
               {
                   db.Update(user);
                   await db.SaveChangesAsync();
                    return Ok(apiUser);
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
