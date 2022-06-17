using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class OrderClass
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int TableId { get; set; }
        public int Opens { get; set; }
        public int WaiterId { get; set; }
        public DateTime Date { get; set; }
    }
}
