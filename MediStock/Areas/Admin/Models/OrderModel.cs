using DAL.Domains;
using System;

namespace MediStockWeb.Areas.Admin.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ShoppingCartId { get; set; }
        public Cart ShoppingCart { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
