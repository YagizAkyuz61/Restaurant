using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Api.Data;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public FoodController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpGet]
        public IActionResult GetFood()
        {
            var foods = from food in _restaurantDb.FoodTable
                        orderby food.CategoryId ascending
                        select new
                        {
                            Id = food.Id,
                            FoodName = food.FoodName,
                            CategoryId = food.CategoryId,
                            Price = food.Price
                        };
            return Ok(foods);
        }

        [HttpPost]
        public IActionResult Post([FromBody] FoodClass food)
        {
            _restaurantDb.FoodTable.Add(food);
            _restaurantDb.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FoodClass food)
        {
            var foods = _restaurantDb.FoodTable.Find(id);
            if (foods == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                foods.FoodName = food.FoodName;
                foods.CategoryId = food.CategoryId;
                foods.Price = food.Price;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var foods = _restaurantDb.FoodTable.Find(id);
            if (foods == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.FoodTable.Remove(foods);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
