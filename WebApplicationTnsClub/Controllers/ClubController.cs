using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.Controllers.Models;
using WebApplicationTnsClub.DB;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/clubs")]
    public class ClubController : Controller
    {
        ApplicationContext db;
        public ClubController(ApplicationContext context)
        {
            db = context;
            if (!db.Clubs.Any())
            {
                //  db.Users.Add(new User { name = "iPhone X", last_name = "Apple", login = "79900" });
                //  db.Users.Add(new User { name = "Galaxy S8", last_name = "Samsung", login = "49900 "});
                //  db.Users.Add(new User { name = "Pixel 2", last_name = "Google", login = "52900" });
                //  db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<Club>> Get()
        { //todo
            return await db.Clubs.ToListAsync();
        }
    
        [HttpGet("{id}")]
        public async Task<Club> Get(long id)
        {
            Club club = await db.Clubs.FirstOrDefaultAsync(x => x.Id== id);
            return club;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Club club)
        {
            if (ModelState.IsValid)
            {
    
                await db.Clubs.AddAsync(club);
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
                
                return Ok(club);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Club club)
        {
            if (ModelState.IsValid)
            {
                db.Update(club);
                await db.SaveChangesAsync();
                return Ok(club);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            Club club = await db.Clubs.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (club != null)
            {
                db.Clubs.Remove(club);
                await db.SaveChangesAsync();
            }
            return Ok(club);
        }
    }
}
