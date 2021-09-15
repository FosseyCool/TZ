using System;
using System.Collections.Generic;
using TZ.Model;

namespace TZ.Data
{
    public interface IOrderRepo
    {
        IEnumerable<Order> GetOrders();

        Order GetOrderById(Guid id);

        Order AddOrder(Order order);
    }
}