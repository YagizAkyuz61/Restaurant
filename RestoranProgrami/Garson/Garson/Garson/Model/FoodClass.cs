using System;
using System.Collections.Generic;
using System.Text;

namespace Garson.Model
{
    public class FoodClass
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
    }
}
