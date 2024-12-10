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
    [Route("api/shedule-club")]
    public class SheduleClubController : Controller
    {
        ApplicationContext db;
        public SheduleClubController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<IEnumerable<SheduleClubParameters>> Get()
        { //todo
            List<SheduleClubParameters> sheduleClubParameters = new List<SheduleClubParameters>();
            try
            {

                List<SheduleClub> sheduleClubs = await db.Set<SheduleClub>().ToListAsync();
                foreach (SheduleClub item in sheduleClubs)
                {
                    sheduleClubParameters.Add(SheduleClubParameters.FromSheduleClub(item));

                }
                return sheduleClubParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<SheduleClubParameters> Get(long id)
        {
            SheduleClub sheduleClub = await db.SheduleClubs.FirstOrDefaultAsync(x => x.Id == id);
            SheduleClubParameters sheduleClubParameters = SheduleClubParameters.FromSheduleClub(sheduleClub);
            return sheduleClubParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(SheduleClubParameters sheduleClubParameters)
        {
            if (ModelState.IsValid)
            {
                SheduleClub sheduleClub = new SheduleClub();
                try
                {
                    sheduleClub=sheduleClubParameters.ToSheduleClub(sheduleClub);
                    await db.SheduleClubs.AddAsync(sheduleClub);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
                return Ok(sheduleClubParameters);
            }

            return BadRequest(ModelState);
        }



        [HttpPut]
        public async Task<IActionResult> Put(SheduleClubParameters sheduleClubParameters)
        {
            if (ModelState.IsValid)
            {
                SheduleClub sheduleClub = db.SheduleClubs.Where(sheduleClub => sheduleClub.Id == sheduleClubParameters.Id).First();

                sheduleClub = sheduleClubParameters.ToSheduleClub(sheduleClub);
                try
                {
                    db.Update(sheduleClub);
                    await db.SaveChangesAsync();
                    return Ok(sheduleClubParameters);
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
        public async Task<IActionResult> Delete(long id)
        {
            SheduleClub sheduleClub = await db.SheduleClubs.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (sheduleClub != null)
            {
                sheduleClub.IsDeleted = true;
                db.SheduleClubs.Remove(sheduleClub   );
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}
