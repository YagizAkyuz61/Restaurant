using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa.Model
{
    class ReservationClass
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string TableName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }
}
