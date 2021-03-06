﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double price { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

        public Product()
        {
            Sales = new HashSet<Sale>();
        }
    }
}