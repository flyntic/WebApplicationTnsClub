using System.Collections.Generic;
using System.Linq;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;

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
          public IEnumerable<User> Get()
          {
              return db.Users.ToList();
          }
 /*
        public async Task<IEnumerable<User>> Get()
        {
            return db.Users
                //      .Include(x => x.Id)
                //      .Select(x =>
                //          new User
                 //         {
                 //             Title = x.Title,
                 //             DateTime = x.WhenCreated,
                 //             AuthorName = x.Author?.UserName ?? string.Empty
                 ////         }
                 //     )
                      .ToListAsync();
        }
*/
      [HttpGet("{id}")]
        public User Get(int id)
        {
            User user= db.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(User user)
        {
            if (ModelState.IsValid)
            {
                db.Update(user);
                db.SaveChanges();
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return Ok(user);
        }
    }
}
