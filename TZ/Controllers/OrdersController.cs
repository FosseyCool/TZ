using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TZ.Data;
using TZ.Model;

namespace TZ.Controllers
{
    [ApiController]
    public class OrdersController : Controller
    {
        private IOrderRepo _orderRepo;

        public OrdersController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
          return Ok(_orderRepo.GetOrders());

         
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(Guid id)
        {
            return _orderRepo.GetOrderById(id);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddOrder(Order order)
        {
            _orderRepo.AddOrder(order);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path +
                           "/" +
                           order.Id, order);
        }
    }
}