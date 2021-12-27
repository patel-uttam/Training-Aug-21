using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;
using UrbanCompany.API.Authentication;
using UrbanCompany.API.Repository;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanCompany.API.Controllers
{
    [Route("api/customer/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;


        public OrderController(IOrderRepository order )
        {
            orderRepository = order;

        }

        // GET api/<OrderController>/5
        [Authorize(Roles = Roles.User)]
        [HttpGet("history/{id}")]
        public IEnumerable<OrderHistory> Get(int id)
        {
            return orderRepository.GetOrderHistory(id);
        }

        // POST api/<OrderController>
        [Authorize(Roles = Roles.User)]
        [HttpPost("{id}")]
        public Order Post(int id, [FromBody] IEnumerable<Cart> carts)
        {
            return orderRepository.Make_Order(id, carts);
        }

    }
}
