using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class ProductReviewController
    {
        private List<Product> _products;

        public ProductReviewController()
        {
            Create();
        }

        /// <summary> Create list of products</summary>
        public void Create()
        {
            _products = new List<Product>()
            {
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 3.4, IsLike = true},
                new Product() {Id = 2, UserId = 3, Review = "bad", Rating = 2.4, IsLike = true},
                new Product() {Id = 3, UserId = 5, Review = "ok", Rating = 2.5, IsLike = true},
                new Product() {Id = 4, UserId = 2, Review = "good", Rating = 4.0, IsLike = true},
                new Product() {Id = 5, UserId = 4, Review = "great", Rating = 5.0, IsLike = true}
            };
        }

        /// <summary> View All products</summary>
        public void View()
        {
            foreach (var product in _products) { Console.WriteLine(product); }
        }

        /// <summary> Overloaded View() All to view products from given list</summary>
        public void View(List<Product> list)
        {
            foreach (var product in list) { Console.WriteLine(product); }
        }

        /// <summary> Retrrieve Top 3 Product based on rating in descending order</summary>
        public List<Product> RetrieveTopThree()
        {
            return (from p in _products orderby p.Rating descending select p).Take(3).ToList();
        }

        /// <summary> Retrrieve Product based on rating > 3 and is 1, 4 or 9</summary>
        public List<Product> RetrieveBasedOnRatingAndId()
        {
            return (from product in _products where product.Rating > 3 && (product.Id == 1 || product.Id == 4 || product.Id == 9) select product).ToList();
        }
    }
}
