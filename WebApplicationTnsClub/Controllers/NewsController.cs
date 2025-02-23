using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using global::WebApplicationTnsClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApplicationTnsClub.Controllers;
using WebApplicationTnsClub.Controllers.Models;
using WebApplicationTnsClub.DB;
using WebApplicationTnsClub.Models.AboutClub;

namespace WebApplicationTnsClub.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class NewsController : Controller
    {
        ApplicationContext db;
        public NewsController(ApplicationContext context)
        {
            db = context;
          
        }
        [HttpGet]
        public async Task<IEnumerable<NewsParameters>> Get()
        { //todo
            List<NewsParameters> newsParameters = new List<NewsParameters>();
            try
            {

                List<News> newses = await db.Set<News>().ToListAsync();
                foreach (News item in newses)
                {
                    newsParameters.Add( NewsParameters.FromNews(item));

                }
                return newsParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<NewsParameters> Get(long id)
        {
            News news= await db.Newses.FirstOrDefaultAsync(x => x.Id == id);
            NewsParameters newsParameters = NewsParameters.FromNews(news);
            return newsParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(NewsParameters newsParameters)
        {
            if (ModelState.IsValid)
            {
                News news = new News();
                try
                {
                    news=newsParameters.ToNews(news);
                    await db.Newses.AddAsync(news);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
                return Ok(newsParameters);
            }

            return BadRequest(ModelState);
        }



        [HttpPut]
        public async Task<IActionResult> Put(NewsParameters newsParameters)
        {
            if (ModelState.IsValid)
            {
                News news = db.Newses.Where(news => news.Id == newsParameters.Id).First();

                news = newsParameters.ToNews(news);
                try
                {
                    db.Update(news);
                    await db.SaveChangesAsync();
                    return Ok(newsParameters);
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
            News news = await db.Newses.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (news != null)
            {
                news.IsDeleted = true;
                db.Newses.Remove(news);
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}