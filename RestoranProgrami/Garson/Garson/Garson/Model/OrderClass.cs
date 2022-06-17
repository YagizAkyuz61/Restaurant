using System;
using System.Collections.Generic;
using System.Text;

namespace Garson.Model
{
    public class OrderClass
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int TableId { get; set; }
        public int Opens { get; set; }
        public DateTime Date { get; set; }
        public int WaiterId { get; set; }
    }
}
