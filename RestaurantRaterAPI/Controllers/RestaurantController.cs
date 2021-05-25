using RestaurantRaterAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace RestaurantRaterAPI.Controllers
{
    public class RestaurantController : ApiController
    {
        private RestaurantDbContext _context = new RestaurantDbContext();


        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (model == null)
            {
                return BadRequest("Your request body cannot be empty");
            }

            if(ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest(ModelState);
        }

        //GetAll
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync(); //returns restaurants as standard list
            return Ok(restaurants); //will pass 200 status and return restaurants - will give all restaurants
        }

        //GetByID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);  //this is like a foreach - will find and return object

            if(restaurant != null)
            {
                return Ok(restaurant);
            }
            return NotFound();
        }

        //Update(PUT)

        //Delete
    }
}