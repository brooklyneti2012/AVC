using AVC.Areas.Identity.Pages.Account.Manage;

namespace AVC.Models.Order
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderProductID { get; set; }
        public int Username { get; set; }

        public OrderProduct OrderProduct { get; set; }
        public IndexModel IndexModel { get; set; }
    }
}
