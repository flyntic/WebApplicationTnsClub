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
    [Route("api/prices")]
    public class PriceController : Controller
    {
        ApplicationContext db;
        public PriceController(ApplicationContext context)
        {
            db = context;
           
        }
        [HttpGet]
        public async Task<IEnumerable<PriceParameters>> Get()
        { //todo
            List<PriceParameters> priceParameters = new List<PriceParameters>();
            try
            {

                List<PriceSessions> prices = await db.Set<PriceSessions>().ToListAsync();
                foreach (PriceSessions item in prices)
                {
                    priceParameters.Add(PriceParameters.FromPrice(item));

                }
                return priceParameters;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<PriceParameters> Get(long id)
        {
            PriceSessions price = await db.PriceSessions.FirstOrDefaultAsync(x => x.Id == id);
            PriceParameters priceParameters = PriceParameters.FromPrice(price);
            return priceParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(PriceParameters priceParameters)
        {
            if (ModelState.IsValid)
            {
                PriceSessions price= new PriceSessions();
                try
                {
                    price=priceParameters.ToPrice(price);
                    await db.PriceSessions.AddAsync(price);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return BadRequest(ModelState);
                }
                return Ok(priceParameters);
            }

            return BadRequest(ModelState);
        }



        [HttpPut]
        public async Task<IActionResult> Put(PriceParameters priceParameters)
        {
            if (ModelState.IsValid)
            {
                PriceSessions price = db.PriceSessions.Where(price => price.Id == priceParameters.Id).First();

                price = priceParameters.ToPrice(price);
                try
                {
                    db.Update(price);
                    await db.SaveChangesAsync();
                    return Ok(priceParameters);
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
            PriceSessions price = await db.PriceSessions.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (price != null)
            {
                price.IsDeleted = true;
                db.PriceSessions.Remove(price);
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}