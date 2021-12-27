using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly UrbanCompanyContext context;
        private readonly IOrderHistoryRepository ohRepository;
        private readonly ICartRepository cartRepository;
        private readonly Order order = new Order();
        public OrderRepository(UrbanCompanyContext _context)
        {
            context = _context;
            ohRepository = new OrderHistoryRepository(_context);
            cartRepository = new CartRepository(_context);
        }



        public Order Make_Order(int id,IEnumerable<Cart> cart)
        {
            
            /*            int customer_id = context.Customers.FirstOrDefault(c => c.CustomerName == name).CustomerId;*/
            int? CustomerId = 0;
            List<int> CartsId=new List<int>();
            int TotalValue=0;


            if (cart.All(c => c.Customer == id))
            {
                foreach (var c in cart)
                {
                    if (c.Customer == id)
                    {
                        CartsId.Add(c.CartId);
                        TotalValue = TotalValue+c.Cost;
                    }
                }
                CustomerId = cart.First(c=>c.Customer==id).Customer;
                order.Customer = CustomerId;
                order.CartReference = string.Join(',',CartsId);
                order.TotalCost = TotalValue;

                context.Orders.Add(order);
                context.SaveChanges();

                // Delete from cart                
                cartRepository.DeleteCarts(id);

                // add to order_history
                ohRepository.AddToOrderHistory(order.OrderId, cart);


                return order;


            }
            return order;
        }

        IEnumerable<OrderHistory> IOrderRepository.GetOrderHistory(int OrderId)
        {
            return context.OrderHistories.Where(oh => oh.OrderId == OrderId);
        }



    }
}