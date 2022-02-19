using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Program
    {
        static void ProductReviewMethods()
        {
            var products = new List<Product>()
            {
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true},
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true},
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true},
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true},
                new Product() {Id = 1, UserId = 1, Review = "good", Rating = 17, IsLike = true},
            };
            var app = new ProductReviewController();
            app.Create(products);
            app.View();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!!!");
            DataTableClass.View(DataTableClass.Create());
        }
    }
}
