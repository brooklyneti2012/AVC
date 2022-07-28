using AVC.Areas.Identity.Pages.Account.Manage;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AVC.Models.Order
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderProductID { get; set; }
        public int Username { get; set; }

        public OrderProduct OrderProduct { get; set; }
        public ICollection<IndexModel> IndexModels { get; set; }
    }
}
