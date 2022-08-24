
using System.Collections.Generic;
namespace AVC.Models
{
    public class OrderProduct
    {
        public int OrderProductID { get; set; }
        public int ProductCategory { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}