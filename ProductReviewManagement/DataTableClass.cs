using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class DataTableClass
    {
        public static DataTable Create()
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("UserId", typeof(int));
            table.Columns.Add("Review");
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("IsLike", typeof(bool));
            table.Rows.Add(1, 1, "good", 6, true);
            table.Rows.Add(2, 3, "bad", 2, true);
            table.Rows.Add(3, 5, "ok", 5, true);
            table.Rows.Add(4, 2, "good", 6, true);
            table.Rows.Add(5, 4, "great", 8, true);
            table.Rows.Add(6, 1, "great", 9, true);
            table.Rows.Add(7, 5, "great", 10, true);
            table.Rows.Add(8, 1, "good", 6, true);
            table.Rows.Add(9, 3, "no", 1, false);
            table.Rows.Add(10, 2, "no", 1, false);
            return table;
        }
        public static void List(List<Product> data)
        {
            foreach (var i in data) { Console.WriteLine(i); }
        }
        public static void RetrieveIsLikeTrueData()
        {
            DataTable table = Create();
            var res = from x in table.AsEnumerable()
                      where x.Field<bool>("IsLike") == true
                      select x;

            List<Product> productList = new List<Product>();
            foreach (var x in res.ToList())
            {
                productList.Add(new Product()
                {
                    Id = x.Field<int>("Id"),
                    UserId = x.Field<int>("UserId"),
                    Review = x.Field<string>("Review"),
                    Rating = x.Field<double>("Rating"),
                    IsLike = x.Field<bool>("IsLike")
                });
            }

            List(productList);
        }
        public static void RetrieveAverageRating()
        {
            DataTable table = Create();
            //double avgRating = (from x in table.AsEnumerable() select x).Average(x => x.Field<double>("Rating"));
            double avgRating = (double)table.Compute("Avg(Rating)", "");
            Console.WriteLine($"Average ratting is : {avgRating}");
        }
    }
}
