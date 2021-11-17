using System;
using System.Collections.Generic;
using System.Text;
using CVTest8.Model;
using CVTest8.Service;

namespace CVTest8.ViewModel
{
    public class SimpleCollectionViewViewModel
    {
        public List<Product> Products { get; set; }

        public SimpleCollectionViewViewModel()
        {
            Products = new ProductService().GetProductList();
        }
    }
}
