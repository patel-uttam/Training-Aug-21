using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly UrbanCompanyContext context;

        public CustomerRepository(UrbanCompanyContext _context)
        {
            context = _context;
        }

        public Customer AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        /*        public void DeleteCustomer(string name)
                {
                    var deleted_customer = context.Customers.FirstOrDefault(c => c.CustomerName == name);
                    context.Remove(deleted_customer);
                    context.SaveChanges();
                }*/


        public Customer GetCustomer(int id)
        {
            var selected_customer = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            return selected_customer;
        }


        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var updated_customer = context.Customers.Attach(customer);
            updated_customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customer;
        }
    }
}
