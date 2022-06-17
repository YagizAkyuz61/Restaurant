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
    public class WaiterController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public WaiterController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpGet]
        public IActionResult GetWaiter()
        {
            var waiters = from waiter in _restaurantDb.WaiterTable
                          select new
                          {
                              Id = waiter.Id,
                              Name = waiter.Name,
                              Surname = waiter.Surname,
                              Nickname = waiter.Nickname,
                              Gender = waiter.Gender
                         };
            return Ok(waiters);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] WaiterClass waiter)
        {
            var waiters = _restaurantDb.WaiterTable.Find(id);
            if (waiters == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                waiters.Name = waiter.Name;
                waiters.Surname = waiter.Surname;
                waiters.Nickname = waiter.Nickname;
                waiters.Gender = waiter.Gender;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var waiter = _restaurantDb.WaiterTable.Find(id);
            if (waiter == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.WaiterTable.Remove(waiter);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
