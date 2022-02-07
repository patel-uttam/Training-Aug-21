using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Day12_13Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day12-13 Assignment");
            bool where_flag = true;
            while (where_flag)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Enter 1 for Search for toy by Category");
                Console.WriteLine("Enter 2 for Purchase Toy");
                Console.WriteLine("Enter 3 for Check Your Cart");
                Console.WriteLine("Enter 4 for Confirm Order");
                Console.WriteLine("Enter 5 for exit");

                Console.Write(">>");  var first_choice = int.Parse(Console.ReadLine());

                using (Toy_Customer_Context context = new Toy_Customer_Context())
                {
                    switch (first_choice)
                    {
                        case 1:
                            Console.WriteLine("What type of toy you want?" + "\t\t" + "Like : Doll,Car,...");
                            var toy_category = Console.ReadLine();

                            var toy_list_category = context.Toys.FromSqlRaw($"Toys_By_Category {toy_category}");

                            foreach (var i in toy_list_category)
                            {
                                Console.WriteLine("Toy's id : " + i.ToyId + " , " + "Toy's category : " + i.ToyType + " , " + "Toy's price : " + i.ToyPayPrice + "\t\t\t" + "Remember toy id for purchase");
                            }
                            Console.WriteLine("\n");
                            break;

                        case 2:

                            Console.WriteLine("Toy Purchase");
                            var toy_list_purchase = context.Toys;
                            Console.WriteLine("Enter Your Id"+"\n");
                            var purchase_customer_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Available Toys");

                            
                            foreach (var i in toy_list_purchase)
                            {
                                
                                Console.WriteLine("Toy's id : " + i.ToyId + " , " + "Toy's category : " + i.ToyType + " , " + "Toy's price : " + i.ToyPayPrice + "\t\t\t" + "Remember toy id for purchase");
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter ToyId of toy you want");
                            int purchase_toy = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number how many toy you want of ToyId :" + purchase_toy);
                            var purchase_toy_count = int.Parse(Console.ReadLine());
                            var toy_id_price = context.Toys.FirstOrDefault(t => t.ToyId == purchase_toy);
                            
                            if (toy_id_price != null && context.Customers.Find(purchase_customer_id)!= null)
                            {
                                Cart cart = new Cart();
                                cart.CustomerId = purchase_customer_id;
                                cart.ToyId = toy_id_price.ToyId;
                                cart.ToyCount = purchase_toy_count;
                                cart.ToyCartPrice = toy_id_price.ToyPayPrice * purchase_toy_count;
                                context.Carts.Add(cart);
                                context.SaveChanges();

                            }
                            /*cart.ToyCartPrice = toy_id_price. * purchase_toy_count;*/
                            break;
                            


                        case 3:
                            break;

                        case 4:
                            Console.WriteLine("Want to Place Order ? y/n");
                            var order_choice = Console.ReadLine();

                            if (order_choice == "y")
                            {
                                Console.WriteLine("Enter your Customer Id");
                                var order_customer_id = int.Parse(Console.ReadLine());

                                //
                                Cart cart = new Cart();
                                var order_cart = context.Carts.Where(c => c.CustomerId == order_customer_id);

                                if (order_cart == null)
                                {
                                    Console.WriteLine("Customer's cart is empty");
                                }
                                else
                                {

                                    var order_customer_customerid = context.Carts.FirstOrDefault(c => c.CustomerId == order_customer_id);

                                    if (order_customer_customerid == null)
                                    {
                                        Console.WriteLine("Customer's cart is empty");
                                    }
                                    else
                                    {


                                        CustomerAddress address = new CustomerAddress();
                                        var order_address = context.CustomerAddresses.Where(c => c.CustomerId == order_customer_customerid.CustomerId).ToArray();


                                        Console.WriteLine("Cart details");

                                        if (order_cart != null)
                                        {

                                            foreach (var i in order_cart)
                                            {
                                                Console.WriteLine("Cartid Id : " + i.CartId + " , " + "Customer Id : " + i.CustomerId + " , " + "Toy Id : " + i.ToyId + "Toy's count : " + i.ToyCount + "Cart Price : " + i.ToyCartPrice);

                                            }

                                            Order order = new Order();
                                            order.CustomerId = order_customer_id;

                                            // address
                                            Console.WriteLine("\n");
                                            Console.WriteLine("order Address ");
                                            foreach (var i in order_address)
                                            {
                                                Console.WriteLine("Address id : " + i.CustomerAddressId + " , " + "Address : " + i.AddressLine);

                                            }
                                            Console.WriteLine("Enter Address id");
                                            int order_final_address = int.Parse(Console.ReadLine());
                                            order.CustomerAddressId = order_address.FirstOrDefault(o => o.CustomerAddressId == order_final_address).CustomerAddressId;

                                            //
                                            order.FinalDiscount = 25;

                                            foreach (var i in order_cart)
                                            {
                                                order.ToyFinalPrice += i.ToyCartPrice;
                                            }
                                            order.ToyFinalPrice = order.ToyFinalPrice - order.FinalDiscount;
                                            Console.WriteLine(order.ToyFinalPrice);

                                            context.Orders.Add(order);
                                            context.SaveChanges();
                                            /*Console.WriteLine*/
                                            /*order.CustomerAddressId = order_address[0].CustomerAddressId;*/
                                        }
                                    }
                                }
                            }
                            break;


                        case 5:
                            where_flag = false;
                            break;
                        default:
                            Console.WriteLine("Enter valid choice");
                            break;
                    }
                }
            }
        }
    }
}
