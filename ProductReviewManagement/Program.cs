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
            Console.WriteLine("\nSkip top 5 records\n======================");
            app.SkifFirstFiveRecords();
            Console.WriteLine("\nRetrieve IsLike==True from datatable\n======================");
            DataTableClass.RetrieveIsLikeTrueData();
            Console.WriteLine("\nRetrieve Average Rating of datatable\n======================");
            DataTableClass.RetrieveAverageRating();
            Console.WriteLine("\nRetrieve Review contains of datatable\n======================");
            DataTableClass.RetrieveReviewContainsNice();
            Console.WriteLine("\nRetrieve data of UserId 10\n======================");
            DataTableClass.RetrieveDataOfCertainUserId(10);
            Console.WriteLine();
            DataTableClass.RetrieveDataOfCertainUserId(10, "desc");
        }
    }
}
