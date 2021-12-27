using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public interface IOrderRepository
    {
        public Order Make_Order(int id, IEnumerable<Cart> cart);

        public IEnumerable<OrderHistory> GetOrderHistory(int OrderId);

        /*
                public IEnumerable<Order> GetOrders(int Cust_id);*/
    }

}
