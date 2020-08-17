﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace well_beings.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description {get;set; }
        public int Quantity { get; set; }
        public string DisplayImage { get; set; }
        public List<string> Images { get; set; }
    }
}
