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

                List<Price> prices = await db.Set<Price>().ToListAsync();
                foreach (Price item in prices)
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
            Price price = await db.Prices.FirstOrDefaultAsync(x => x.Id == id);
            PriceParameters priceParameters = PriceParameters.FromPrice(price);
            return priceParameters;
        }


        [HttpPost]
        public async Task<IActionResult> Post(PriceParameters priceParameters)
        {
            if (ModelState.IsValid)
            {
                Price price= new Price();
                try
                {
                    price=priceParameters.ToPrice(price);
                    await db.Prices.AddAsync(price);
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
                Price price = db.Prices.Where(price => price.Id == priceParameters.Id).First();

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
            Price price = await db.Prices.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (price != null)
            {
                price.IsDeleted = true;
                db.Prices.Remove(price);
                await db.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}