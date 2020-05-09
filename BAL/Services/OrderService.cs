using DAL.Data;
using DAL.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL.Services
{
    public class OrderService : IOrderService
    {
        private readonly MediStockContext context;

        public OrderService(MediStockContext context)
        {
            this.context = context;
        }

        public Order DeleteOrder(Order orderEntity)
        {
            context.Entry(orderEntity).State = EntityState.Deleted;
            context.SaveChanges();

            return orderEntity;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            IList<Order> orderModel = new List<Order>();
            var query = context.Orders.ToList();
            var orderData = query.ToList();
            foreach (var item in orderData)
            {
                orderModel.Add(new Order()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    OrderTotal = item.OrderTotal,
                    DeliveryDateTime = item.DeliveryDateTime,
                   // OrderStatusId = item.OrderStatusId,
                    CreatedOn = item.CreatedOn,
                    ShoppingCartId = item.ShoppingCartId
                   
                });

            }
            return orderData;
        }

            public Order GetOrderById(int orderID)
            {
            var query = from c in context.Orders where c.Id == orderID select c;
            var order = query.FirstOrDefault();
            var model = new Order()
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                OrderTotal = order.OrderTotal,
                DeliveryDateTime = order.DeliveryDateTime,
              //  OrderStatusId = order.OrderStatusId,
                CreatedOn = order.CreatedOn,
                ShoppingCartId = order.ShoppingCartId
            };
            return model;


        }


        public Order InsertOrder(Order orderEntity)
        {
            context.Orders.Add(orderEntity);
            context.SaveChanges();
            return orderEntity;



        }

        public Order UpdateOrder(Order orderEntity)
        {
            context.Entry(orderEntity).State = EntityState.Modified;
            context.SaveChanges();

            return orderEntity;
        }
    }
}
