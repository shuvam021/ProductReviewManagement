using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class ProductReviewController
    {
        private List<Product> _products;

        public void Create()
        {
            _products = new List<Product>()
            {
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 3.4, IsLike = true},
                new Product() {Id = 2, UserId = 3, Review = "bad", Rating = 2.4, IsLike = true},
                new Product() {Id = 3, UserId = 5, Review = "ok", Rating = 2.5, IsLike = true},
                new Product() {Id = 4, UserId = 2, Review = "good", Rating = 4, IsLike = true},
                new Product() {Id = 5, UserId = 4, Review = "great", Rating = 5, IsLike = true}
            };
        }

        public void View()
        {
            foreach (var product in _products) { Console.WriteLine(product); }
        }
    }
}
