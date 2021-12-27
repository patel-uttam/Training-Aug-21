using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{

    public class CartRepository : ICartRepository
    {
        private readonly UrbanCompanyContext context;

        public CartRepository(UrbanCompanyContext _context)
        {
            context = _context;
        }


        //view cart for customer
        public Cart AddToCart(int id , Cart cart)
        {
            Cart c = null;
            Provider p = null;
/*            ServicesCategory s = null;*/
/*            int customerid = context.Customers.FirstOrDefault(c=>c.CustomerName == name).CustomerId;*/
            if(cart.Customer == id && cart.ServiceCategory == context.Providers.FirstOrDefault(p => p.ProviderId == cart.Provider).Service && cart.ServiceCategory == context.SubServices.FirstOrDefault(s => s.SubServiceId == cart.Service).ServiceId)
            {                
                context.Carts.Add(cart);
                context.SaveChanges();
            }
            return cart;
        }



        public IEnumerable<Cart> GetCart(int id)
        {
/*            var customerid = context.Customers.FirstOrDefault(x=>x.CustomerName == name);*/
            var selected_cart_view = context.Carts.Where(c=>c.Customer == id);
            return selected_cart_view;
        }

        public void DeleteCart(int Cust_id , int Cart_id)
        {
/*            int customer_id = context.Customers.FirstOrDefault(c=>c.CustomerName == name).CustomerId;*/
            var cart_items = context.Carts.Where(c => c.Customer == Cust_id);

            /*            var cart_item = from i in cart_items select i.CartId;*/
            Console.WriteLine(Cart_id);
            foreach (var i in cart_items)
            {
                if (i.CartId == Cart_id)
                {
                    context.Carts.Remove(i);
                }
            }
            context.SaveChanges();


        }

        public void DeleteCarts(int Cust_id)
        {
            IEnumerable<Cart> Cart_Deletes = context.Carts.Where(c => c.Customer == Cust_id);
            Console.WriteLine(Cust_id);
            foreach(var c_delete in Cart_Deletes)
            {
                context.Carts.Remove(c_delete);
                

            }
            context.SaveChanges();
        }
    }
}
                      






       