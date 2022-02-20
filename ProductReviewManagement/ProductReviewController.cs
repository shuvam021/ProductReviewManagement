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
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 6, IsLike = true},
                new Product() {Id = 2, UserId = 3, Review = "bad", Rating = 2, IsLike = true},
                new Product() {Id = 3, UserId = 5, Review = "ok", Rating = 5, IsLike = true},
                new Product() {Id = 4, UserId = 2, Review = "good", Rating = 6, IsLike = true},
                new Product() {Id = 5, UserId = 4, Review = "great", Rating = 8, IsLike = true},
                new Product() {Id = 6, UserId = 1, Review = "great", Rating = 9, IsLike = true},
                new Product() {Id = 7, UserId = 5, Review = "great", Rating = 10, IsLike = true},
                new Product() {Id = 8, UserId = 1, Review = "good", Rating = 6, IsLike = true},
                new Product() {Id = 9, UserId = 3, Review = "no", Rating = 1, IsLike = false},
                new Product() {Id = 10, UserId = 2, Review = "no", Rating = 1, IsLike = false},
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

        /// <summary>count of review present for each product</summary>
        public void CountIdGroupByReview()
        {
            var res = (_products.GroupBy(p => p.Rating).Select(x => new { rating = x.Key, count = x.Count() })).ToList();
            foreach (var item in res)
            {
                Console.WriteLine($"NewObj(Ratting:{item.rating}, Count:{item.count})");
            }
        }

        /// <summary>retrieve productid and review</summary>
        public void RetrieveProductIdAndReview()
        {
            var res = (_products.Select(x => new { Id = x.Id, Review = x.Review })).ToList();
            foreach (var item in res)
            {
                Console.WriteLine($"Id:{item.Id}, Review:{item.Review})");
            }
        }

        /// <summary>retrieve productid and review</summary>
        public void SkifFirstFiveRecords()
        {
            View(_products.Skip(5).ToList());
        }

    }
}
