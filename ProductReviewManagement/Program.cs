using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main()
        {
            var app = new ProductReviewController();
            Console.WriteLine("All Products\n======================");
            app.View();
            Console.WriteLine("\nTop 3 based on Rating\n======================");
            app.View(app.RetrieveTopThree());
            Console.WriteLine("\nFatch product\n======================");
            app.View(app.RetrieveBasedOnRatingAndId());
            Console.WriteLine("\nCount\n======================");
            app.CountIdGroupByReview();
            Console.WriteLine("\nRetrieveProductIdAndReview\n======================");
            app.RetrieveProductIdAndReview();
        }
    }
}
