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
            app.Create();
            app.View();
        }
    }
}
