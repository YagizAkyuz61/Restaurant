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
    public class TimeController : ControllerBase
    {
        private readonly List<TimeClass> _time = new List<TimeClass>()
        {
            new TimeClass() {Time = "16:45"},
            new TimeClass() {Time = "17:00"},
            new TimeClass() {Time = "17:30"},
            new TimeClass() {Time = "17:45"},
            new TimeClass() {Time = "18:00"},
            new TimeClass() {Time = "18:30"},
            new TimeClass() {Time = "18:45"},
            new TimeClass() {Time = "19:00"},
            new TimeClass() {Time = "19:30"},
            new TimeClass() {Time = "19:45"},
            new TimeClass() {Time = "20:00"},
            new TimeClass() {Time = "20:30"},
            new TimeClass() {Time = "20:45"},
            new TimeClass() {Time = "21:00"},
            new TimeClass() {Time = "21:30"},
            new TimeClass() {Time = "21:45"},
            new TimeClass() {Time = "22:00"},
            new TimeClass() {Time = "22:30"},
            new TimeClass() {Time = "22:45"},
            new TimeClass() {Time = "23:00"},
            new TimeClass() {Time = "23:30"},
            new TimeClass() {Time = "23:45"}
        };

        public IQueryable<TimeClass> GetTime()
        {
            return _time.AsQueryable();
        }
    }
}
