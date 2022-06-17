using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;

        public ReserController(RestaurantDbContext restaurant)
        {
            _restaurantDb = restaurant;
        }

        // GET: api/<ReserController>
        [HttpGet]
        public IEnumerable<ReservationsClass> Get()
        {
            return _restaurantDb.ReservationsTable;
        }

        // GET api/<ReserController>/5
        [HttpGet("{id}", Name = "Get")]
        public ReservationsClass Get(int id)
        {
            var rd = _restaurantDb.ReservationsTable.Find(id);
            return rd;
        }
    }
}
