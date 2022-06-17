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
    public class TableController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public TableController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TableClass tables)
        {
            _restaurantDb.Tables.Add(tables);
            _restaurantDb.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public IActionResult GetTabe()
        {
            var tables = from table in _restaurantDb.Tables
                       select new
                       {
                           Id = table.Id,
                           TableName = table.TableName
                       };
            return Ok(tables);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TableClass table)
        {
            var tables = _restaurantDb.Tables.Find(id);
            if (tables == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                tables.TableName = table.TableName;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var table = _restaurantDb.Tables.Find(id);
            if (table == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.Tables.Remove(table);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
