using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetCart(int id);

        Cart AddToCart(int id, Cart cart);

        void DeleteCart(int Cust_id , int Cart_id);

        void DeleteCarts(int Cust_id);
    }
}
