using System;
using System.Collections.Generic;
using System.Text;
using CVTest8.Model;

namespace CVTest8.Service
{
    public class ProductService
    {
        public List<Product> GetProductList()
        {
            return new List<Product>()
            {
                new Product(){ProductName="Small Boost Package", ProductDescription="Provides 10 of each boost type", Price=5, ImageUrl="small", ProductID="boost1"},
                new Product(){ProductName="Medium Boost Package", ProductDescription="Provides 25 of each boost type", Price=10, ImageUrl="medium", ProductID="boost2"},
                new Product(){ProductName="Large Boost Package", ProductDescription="Provices 65 of each boost type", Price=25, ImageUrl="large", ProductID="boost3"},
                new Product(){ProductName="Old School Category", ProductDescription="Unlocks the Old School category", Price=3, ImageUrl="categoary", ProductID="category1"},
                new Product(){ProductName="Old School Category", ProductDescription="Unlocks the Old School category", Price=3, ImageUrl="categoary", ProductID="category1"},
                new Product(){ProductName="Late 80's Category", ProductDescription="Unlocks the Late 80's category", Price=3, ImageUrl="categoary", ProductID="category2"},
                new Product(){ProductName="Early 90's Category", ProductDescription="Unlocks the Early 90's category", Price=3, ImageUrl="categoary", ProductID="category3"},
                new Product(){ProductName="Late 90's Category", ProductDescription="Unlocks the Late 90s category", Price=3, ImageUrl="categoary", ProductID="category4"},
                new Product(){ProductName="Early 2000's Category", ProductDescription="Unlocks the Early 2000's category", Price=3, ImageUrl="categoary", ProductID="category5"},
                new Product(){ProductName="Modern Day Category", ProductDescription="Unlocks the Modern Day category", Price=3, ImageUrl="categoary", ProductID="category6"},
                new Product(){ProductName="Unlock All Categories", ProductDescription="Unlocks all categories", Price=10, ImageUrl="retry_button", ProductID="categoryall"},
                new Product(){ProductName="Video Advertisement", ProductDescription="Provides 4 random boosts after watching",Price=0, ImageUrl="playad", ProductID="playad"},

            };
        }
    }
}
