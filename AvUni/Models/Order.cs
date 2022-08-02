
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace AVC.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderProductID { get; set; }
        public int Username { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
      
    }
}
