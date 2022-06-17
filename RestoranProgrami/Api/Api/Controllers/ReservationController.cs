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
    public class ReservationController : ControllerBase
    {
        private RestaurantDbContext _restaurantDb;
        public ReservationController(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDb = restaurantDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ReservationsClass reservations)
        {
            _restaurantDb.ReservationsTable.Add(reservations);
            _restaurantDb.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public IActionResult GetReservation()
        {
            var reservations = from reservation in _restaurantDb.ReservationsTable
                               orderby reservation.Time ascending
                               orderby reservation.Date ascending
                               where reservation.Date >= DateTime.Today
                         select new
                         {
                             Id = reservation.Id,
                             CName = reservation.CName,
                             TableName = reservation.TableName,
                             Date = reservation.Date,
                             Time = reservation.Time
                         };
            return Ok(reservations);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] ReservationsClass reservation)
        {
            var reservations = _restaurantDb.ReservationsTable.Find(id);
            if (reservations == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                reservations.CName = reservation.CName;
                reservations.TableName = reservation.TableName;
                reservations.Date = reservation.Date;
                _restaurantDb.SaveChanges();
                return Ok("Güncelleme başarılı.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reservation = _restaurantDb.ReservationsTable.Find(id);
            if (reservation == null)
            {
                return NotFound("Id'nin doğru olduğuna emin olun.");
            }
            else
            {
                _restaurantDb.ReservationsTable.Remove(reservation);
                _restaurantDb.SaveChanges();
                return Ok("Silme başarılı.");
            }
        }
    }
}
