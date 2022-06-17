using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa.Model
{
    public class ListOrderClass
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string TableName { get; set; }
        public int FoodPrice { get; set; }
        public int WId { get; set; }
    }
}
