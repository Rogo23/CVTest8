using System;
using System.Collections.Generic;
using System.Text;

namespace CVTest8.Model
{
    public class ProductGroup : List<Product>
    {
        public string Name { get; private set; }

        public ProductGroup(string name, List<Product> products) : base(products)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
