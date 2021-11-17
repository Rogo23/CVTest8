using System;
using System.Collections.Generic;
using System.Text;

namespace CVTest8.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ProductID { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
