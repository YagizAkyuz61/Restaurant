using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class ReservationsClass
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string TableName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}
