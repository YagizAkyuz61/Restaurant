using Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodSeController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public FoodSeController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpGet("{id}")]
        [HttpGet]
        public IActionResult GetF(int id)
        {
            var foods = from food in _restaurantDb.FoodTable
                        where food.Id == id
                        select new
                        {
                            Id = food.Id,
                            FoodName = food.FoodName,
                            CategoryId = food.CategoryId,
                            Price = food.Price
                        };
            return Ok(foods);
        }
    }
}
