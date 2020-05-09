using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public interface IOrderService
    {
        public IEnumerable<Order>GetAllOrders();
        public Order GetOrderById(int orderID);
        public Order InsertOrder(Order orderEntity);
        public Order UpdateOrder(Order orderEntity);
        public Order DeleteOrder(Order orderEntity);
    }
}
