﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa.Model
{
    class FoodClass
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
    }
}
