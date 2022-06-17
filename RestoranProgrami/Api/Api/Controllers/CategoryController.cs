using Api.Data;
using Api.Model;
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
    public class CategoryController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public CategoryController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryClass category)
        {
            _restaurantDb.CategoryTable.Add(category);
            _restaurantDb.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            var cate = from category in _restaurantDb.CategoryTable
                       select new
                       {
                           Id = category.Id,
                           CategoryName = category.CategoryName
                       };
            return Ok(cate);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CategoryClass category)
        {
            var cate = _restaurantDb.CategoryTable.Find(id);
            if (cate == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                cate.CategoryName = category.CategoryName;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _restaurantDb.CategoryTable.Find(id);
            if (category == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.CategoryTable.Remove(category);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
