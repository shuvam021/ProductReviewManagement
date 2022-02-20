using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Product
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
        public override string ToString()
        {
            return $"Product({Id}, {UserId}, {Rating}, {Review}, {IsLike})";
        }
    }
}
