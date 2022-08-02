using System.Collections.Generic;

namespace AVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
