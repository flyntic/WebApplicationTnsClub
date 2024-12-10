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
    [Route("api/sessions")]
    public class SessionController : Controller
    {
        ApplicationContext db;
        public SessionController(ApplicationContext context)
        {
            db = context;
     
        }
        [HttpGet]
        public async Task<IEnumerable<SessionParameters>> Get()
        { //todo
            List<SessionParameters> sessionParameters = new List<SessionParameters>();
            try
            {

                List<Session> sessions = await db.Set<Session>().ToListAsync();
                foreach (Session item in sessions)
                {
                    sessionParameters.Add(SessionParameters.FromSession(item));

                }
                return sessionParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<SessionParameters> Get(long id)
        {
            Session session = await db.Sessions.FirstOrDefaultAsync(x => x.Id == id);
            SessionParameters sessionParameters = SessionParameters.FromSession(session);
            return sessionParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(SessionParameters sessionParameters)
        {
            if (ModelState.IsValid)
            {
                Session session = new Session();
                try
                {
                    session=sessionParameters.ToSession(session);
                    await db.Sessions.AddAsync(session);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
                return Ok(sessionParameters);
            }

            return BadRequest(ModelState);
        }



        [HttpPut]
        public async Task<IActionResult> Put(SessionParameters sessionParameters)
        {
            if (ModelState.IsValid)
            {
                Session session = db.Sessions.Where(session => session.Id == sessionParameters.Id).First();

                session = sessionParameters.ToSession(session);
                try
                {
                    db.Update(session);
                    await db.SaveChangesAsync();
                    return Ok(sessionParameters);
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
            Session session = await db.Sessions.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (session != null)
            {
                session.IsDeleted = true;
                db.Sessions.Remove(session);
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}