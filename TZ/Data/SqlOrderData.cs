using System;
using System.Collections.Generic;
using System.Linq;
using TZ.Model;

namespace TZ.Data
{
    public class SqlOrderData :IOrderRepo
    {
        private OrderContext _orderContext;
        public SqlOrderData(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _orderContext.Orders.ToList();
        }

        public Order GetOrderById(Guid id)
        {
            var order = _orderContext.Orders.Find(id);
            return order;
        }

        public Order AddOrder(Order order)
        {
            order.Id=Guid.NewGuid();
            _orderContext.Orders.Add(order);
            _orderContext.SaveChanges();
            return order;
        }
    }
}