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
            table.Rows.Add(1, 1, "nice", 6, true);
            table.Rows.Add(2, 3, "bad", 2, true);
            table.Rows.Add(3, 5, "ok", 5, true);
            table.Rows.Add(4, 2, "good", 6, true);
            table.Rows.Add(5, 4, "great", 8, true);
            table.Rows.Add(6, 10, "great", 9, true);
            table.Rows.Add(7, 10, "great", 10, true);
            table.Rows.Add(8, 10, "nice", 6, true);
            table.Rows.Add(9, 10, "no", 1, false);
            table.Rows.Add(10, 10, "no", 1, false);
            return table;
        }
        public static void View(EnumerableRowCollection<DataRow> data)
        {
            List<Product> productList = new List<Product>();
            foreach (var x in data.ToList())
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
            foreach (var i in productList) { Console.WriteLine(i); }
        }
        public static void RetrieveIsLikeTrueData()
        {
            DataTable table = Create();
            var res = from x in table.AsEnumerable()
                      where x.Field<bool>("IsLike") == true
                      select x;

            View(res);
        }
        public static void RetrieveAverageRating()
        {
            DataTable table = Create();
            double avgRating = (double)table.Compute("Avg(Rating)", "");
            Console.WriteLine($"Average ratting is : {avgRating}");
        }
        public static void RetrieveReviewContainsNice()
        {
            var res= from x in Create().AsEnumerable()
                     where x.Field<string>("Review").ToLower() == "nice" 
                     select x;
            View(res);
        }
        public static void RetrieveDataOfCertainUserId(int id, string order= "asc")
        {
            EnumerableRowCollection<DataRow> res;

            if (order != null && order == "desc")
            {
                res = from x in Create().AsEnumerable()
                     where x.Field<int>("UserId") == id
                     orderby x.Field<double>("Rating") descending
                     select x;
            }
            else
            {
                res = from x in Create().AsEnumerable()
                      where x.Field<int>("UserId") == id
                      orderby x.Field<double>("Rating")
                      select x;
            }
            View(res);
        }
    }
}
