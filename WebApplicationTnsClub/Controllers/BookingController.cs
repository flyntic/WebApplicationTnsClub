using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.DB;
using WebApplicationTnsClub.Models.Bookings;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingController : Controller
    {
        ApplicationContext db;
        public BookingController(ApplicationContext context)
        {
            db = context;
            if (!db.Bookings.Any())
            {
                //  db.Users.Add(new User { name = "iPhone X", last_name = "Apple", login = "79900" });
                //  db.Users.Add(new User { name = "Galaxy S8", last_name = "Samsung", login = "49900 "});
                //  db.Users.Add(new User { name = "Pixel 2", last_name = "Google", login = "52900" });
                //  db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<Booking>> Get()
        {
            return await db.Bookings.ToListAsync();
        }
    
        [HttpGet("{id}")]
        public async Task<Booking> Get(long id)
        {
            Booking booking = await db.Bookings.FirstOrDefaultAsync(x => x.Id == id);
            return booking;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Booking booking)
        {
            if (ModelState.IsValid)
            {
    
                await db.Bookings.AddAsync(booking);
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
                
                return Ok(booking);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Update(booking);
                await db.SaveChangesAsync();
                return Ok(booking);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            Booking booking = await db.Bookings.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (booking != null)
            {
                db.Bookings.Remove(booking);
                await db.SaveChangesAsync();
            }
            return Ok(booking);
        }
    }
}
