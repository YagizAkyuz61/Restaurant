using System;
using System.Collections.Generic;
using System.Text;

namespace Rezervasyon.Model
{
    public class ReservationClass
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string TableName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}
