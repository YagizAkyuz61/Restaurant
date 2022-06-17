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
    public class OrderSeController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public OrderSeController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpGet("{id}")]
        [HttpGet]
        public IActionResult GetOrder(int id)
        {
            var orders = from order in _restaurantDb.OrderTable
                         join f in _restaurantDb.FoodTable on order.FoodId equals f.Id
                         join t in _restaurantDb.Tables on order.TableId equals t.Id
                         where order.TableId == id
                             where order.Opens == 1
                             select new
                             {
                                 Id = order.Id,
                                 FoodName = f.FoodName,
                                 TableName = t.TableName,
                                 FoodPrice = f.Price,
                                 WId = order.WaiterId
                             };
            return Ok(orders);
        }
    }
}
