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
    [Route("api/shedule-club-open-bookings")]
    public class SheduleClubOpenBookingController : Controller
    {
        ApplicationContext db;
        public SheduleClubOpenBookingController(ApplicationContext context)
        {
            db = context;
            
        }
        [HttpGet]
        public async Task<IEnumerable<SheduleClubOpenBookingParameters>> Get()
        { //todo
            List<SheduleClubOpenBookingParameters> sheduleClubOpenBookingParameters = new List<SheduleClubOpenBookingParameters>();
            try
            {

                List<SheduleClubOpenBooking> sheduleClubOpenBookings = await db.Set<SheduleClubOpenBooking>().ToListAsync();
                foreach (SheduleClubOpenBooking item in sheduleClubOpenBookings)
                {
                    sheduleClubOpenBookingParameters.Add(SheduleClubOpenBookingParameters.FromSheduleClubOpenBooking(item));

                }
                return sheduleClubOpenBookingParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<SheduleClubOpenBookingParameters> Get(long id)
        {
            SheduleClubOpenBooking sheduleClubOpenBooking = await db.SheduleClubOpenBookings.FirstOrDefaultAsync(x => x.Id == id);
            SheduleClubOpenBookingParameters sheduleClubOpenBookingParameters = SheduleClubOpenBookingParameters.FromSheduleClubOpenBooking(sheduleClubOpenBooking);
            return sheduleClubOpenBookingParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(SheduleClubOpenBookingParameters sheduleClubOpenBookingParameters)
        {
            if (ModelState.IsValid)
            {
                SheduleClubOpenBooking sheduleClubOpenBooking = new SheduleClubOpenBooking();
                try
                {
                    sheduleClubOpenBooking=sheduleClubOpenBookingParameters.ToSheduleClubOpenBooking(sheduleClubOpenBooking);
                    await db.SheduleClubOpenBookings.AddAsync(sheduleClubOpenBooking);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
                return Ok(sheduleClubOpenBookingParameters);
            }

            return BadRequest(ModelState);
        }



        [HttpPut]
        public async Task<IActionResult> Put(SheduleClubOpenBookingParameters sheduleClubOpenBookingParameters)
        {
            if (ModelState.IsValid)
            {
                SheduleClubOpenBooking sheduleClubOpenBooking = db.SheduleClubOpenBookings.Where(sheduleClubOpenBooking => sheduleClubOpenBooking.Id == sheduleClubOpenBookingParameters.Id).First();

                sheduleClubOpenBooking = sheduleClubOpenBookingParameters.ToSheduleClubOpenBooking(sheduleClubOpenBooking);
                try
                {
                    db.Update(sheduleClubOpenBooking);
                    await db.SaveChangesAsync();
                    return Ok(sheduleClubOpenBookingParameters);
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
            SheduleClubOpenBooking sheduleClubOpenBooking = await db.SheduleClubOpenBookings.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (sheduleClubOpenBooking != null)
            {
                sheduleClubOpenBooking.IsDeleted = true;
                db.SheduleClubOpenBookings.Remove(sheduleClubOpenBooking);
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}
