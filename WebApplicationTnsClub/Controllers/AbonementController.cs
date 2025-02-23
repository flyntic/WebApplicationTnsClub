using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.Controllers.Models;
using WebApplicationTnsClub.Controllers;
using WebApplicationTnsClub.DB;
using WebApplicationTnsClub.Models.Abonements;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/abonement")]
    public class AbonementController : Controller
    {
        ApplicationContext db;
        public AbonementController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AbonementParameters>> Get()
        {
           List<AbonementParameters> abonementParameters = new List<AbonementParameters>();
           try
            {
         /*       List<GroupAbonement> abonements = await db.Abonements.ToListAsync();
                foreach (var item in abonements)
                {
                    abonementParameters.Add(AbonementParameters.FromAbonement(item));
                    
                }*/
                return abonementParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    
  /*      [HttpGet("{id}")]
        public async Task<AbonementParameters> Get(long id)
        {
        //   GroupAbonement abonement;// = await db.Abonements.FirstOrDefaultAsync(x => x.Id == id);
                    
         //   return AbonementParameters.FromAbonement(abonement);
        }*/

        [HttpPost]
        public async Task<IActionResult> Post(AbonementParameters abonementParameters)
        {
            if (ModelState.IsValid)
            {
              //  Console.WriteLine("add user" + user.ToString());
//                await db.Abonements.AddAsync(abonementParameters.ToAbonement(new GroupAbonement()));//.toNewUser()
              //  Console.WriteLine("add");
                db.SaveChanges();
             //   Console.WriteLine("end add");

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
                
                return Ok(abonementParameters);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AbonementParameters abonementParameters)
        {
            if (ModelState.IsValid)
            {
                //todo  db.Update(abonementParameters.ToAbonementParameters());
                await db.SaveChangesAsync();
                return Ok(abonementParameters);
            }
            return BadRequest(ModelState);
        }

  /*      [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            GroupAbonement abonement = await db.Abonements.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (abonement != null)
            {
                abonement.IsDeleted = true;
               // db.Users.Remove(user);
                await db.SaveChangesAsync();
            }
            return Ok(abonement);  
         }*/
    }
}
