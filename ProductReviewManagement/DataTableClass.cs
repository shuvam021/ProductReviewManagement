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
            table.Columns.Add("Id");
            table.Columns.Add("UserId");
            table.Columns.Add("Review");
            table.Columns.Add("Rating");
            table.Columns.Add("IsLike");
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
    }
}
