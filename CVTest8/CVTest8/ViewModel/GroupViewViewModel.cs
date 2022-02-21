using System;
using System.Collections.Generic;
using System.Text;
using CVTest8.Model;
using CVTest8.Service;

namespace CVTest8.ViewModel
{
    public class GroupViewViewModel
    {
        
        public List<ProductGroup> PG { get; private set; } = new List<ProductGroup>();


        public GroupViewViewModel()
        {
            PG.Add(new ProductGroup("Boost Packages", new List<Product>
            {
                new Product(){ProductName="Small Boost Package", ProductDescription="Provides 10 of each boost type", Price=5, ImageUrl="boost1", ProductID="boost1"},
                new Product(){ProductName="Medium Boost Package", ProductDescription="Provides 25 of each boost type", Price=10, ImageUrl="boost2", ProductID="boost2"},
                new Product(){ProductName="Large Boost Package", ProductDescription="Provides 65 of each boost type", Price=25, ImageUrl="boost3", ProductID="boost3"},
                
            }));

            PG.Add(new ProductGroup("Available Category Unlocks", new List<Product>
            {
                new Product(){ProductName="Old School Category", ProductDescription="Unlocks the Old School category", Price=3, ImageUrl="category7", ProductID="category7"},
                new Product(){ProductName="Late 80's Category", ProductDescription="Unlocks the Late 80's category", Price=3, ImageUrl="category2", ProductID="category2"},
                new Product(){ProductName="Early 90's Category", ProductDescription="Unlocks the Early 90's category", Price=3, ImageUrl="category3", ProductID="category3"},
                new Product(){ProductName="Late 90's Category", ProductDescription="Unlocks the Late 90s category", Price=3, ImageUrl="category4", ProductID="category4"},
                new Product(){ProductName="Early 2000's Category", ProductDescription="Unlocks the Early 2000's category", Price=3, ImageUrl="category5", ProductID="category5"},
                new Product(){ProductName="Modern Day Category", ProductDescription="Unlocks the Modern Day category", Price=3, ImageUrl="category6", ProductID="category6"},
                new Product(){ProductName="Unlock All Categories", ProductDescription="Unlocks all categories", Price=10, ImageUrl="categoryall", ProductID="categoryall"},
            }));

            PG.Add(new ProductGroup("Subscription Options", new List<Product>
            {
                new Product(){ProductName="Preliminary Subscription", ProductDescription="Unlocks all categories plus 5 of each boost type per month",Price=30, ImageUrl="subscription1", ProductID="subscription1"},
                new Product(){ProductName="Main Event Subscription", ProductDescription="Unlocks all categories plus 15 of each boost type per month",Price=60, ImageUrl="subscription2", ProductID="subscription2"},
            }));

            PG.Add(new ProductGroup("Rewarded Advertisement", new List<Product>
            {
                new Product(){ProductName="Video Advertisement", ProductDescription="Provides 3 random boosts after watching",Price=0, ImageUrl="rewardedAd", ProductID="rewardedAd"}
            }));

        }
    }
}
