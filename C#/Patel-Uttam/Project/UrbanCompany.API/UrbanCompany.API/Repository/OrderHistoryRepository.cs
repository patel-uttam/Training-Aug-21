using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public class OrderHistoryRepository : IOrderHistoryRepository
    {
        private readonly UrbanCompanyContext context;
        public OrderHistoryRepository(UrbanCompanyContext _context)
        {
            context = _context;
        }

        void IOrderHistoryRepository.AddToOrderHistory(int orderId , IEnumerable<Cart> cart)
        {

            foreach(var c in cart)
            {
                Models.OrderHistory oh = new Models.OrderHistory();

                oh.OrderId = orderId;
                oh.Customer = c.Customer;
                oh.ServiceCategory = c.ServiceCategory;
                oh.Service = c.Service;
                oh.Provider = c.Provider;
                oh.Cost = c.Cost;
                context.OrderHistories.Add(oh);
                context.SaveChanges();
                
            }

        }


    }
}
