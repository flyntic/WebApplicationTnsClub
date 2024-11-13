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
    [Route("api/rates")]
    public class RateController : Controller
    {
        ApplicationContext db;
        public RateController(ApplicationContext context)
        {
            db = context;
            if (!db.Rates.Any())
            {
                //  db.Users.Add(new User { name = "iPhone X", last_name = "Apple", login = "79900" });
                //  db.Users.Add(new User { name = "Galaxy S8", last_name = "Samsung", login = "49900 "});
                //  db.Users.Add(new User { name = "Pixel 2", last_name = "Google", login = "52900" });
                //  db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<ApiRate>> Get()
        {
           List<ApiRate> apiRates = new List<ApiRate>();
           try
            {
                List<Rate> rates = await db.Rates.ToListAsync();
                foreach (var rate in rates)
                {
                    apiRates.Add(rate.toApi());
                    
                }
                return apiRates;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    
        [HttpGet("{id}")]
        public async Task<ApiRate> Get(long id)
        {
                Rate rate = await db.Rates.FirstOrDefaultAsync(x => x.Id == id);
                    
            return rate.toApi();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ApiRate rate)
        {
            if (ModelState.IsValid)
            {
               // Console.WriteLine("add user" + user.ToString());
                await db.Rates.AddAsync(rate);//.toNewUser()
              //  Console.WriteLine("add");
                db.SaveChanges();
               // Console.WriteLine("end add");

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
                
                return Ok(rate);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ApiRate rate)
        {
            if (ModelState.IsValid)
            {
              //todo  db.Update(user.toUser());
                await db.SaveChangesAsync();
                return Ok(rate);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            Rate rate = await db.Rates.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (rate != null)
            {
                rate.IsDeleted = true;
               // db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(rate);
        }
    }
}
