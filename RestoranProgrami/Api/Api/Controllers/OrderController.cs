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
    public class OrderController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public OrderController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderClass order)
        {
            _restaurantDb.OrderTable.Add(order);
            _restaurantDb.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            var orders = from order in _restaurantDb.OrderTable
                         join f in _restaurantDb.FoodTable on order.FoodId equals f.Id
                         join t in _restaurantDb.Tables on order.TableId equals t.Id
                         join w in _restaurantDb.WaiterTable on order.WaiterId equals w.Id
                         where order.Date == DateTime.Today
                         select new
                        {
                            Id = order.Id,
                            FoodName = f.FoodName,
                            TableName = t.TableName,
                            FoodPrice = f.Price,
                            WId = order.WaiterId,
                            Waiter = w.Name + " " + w.Surname
                        };
            return Ok(orders);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] OrderClass order)
        {
            var orders = _restaurantDb.OrderTable.Find(id);
            if (orders == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                orders.Opens = order.Opens;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _restaurantDb.OrderTable.Find(id);
            if (order == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.OrderTable.Remove(order);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
