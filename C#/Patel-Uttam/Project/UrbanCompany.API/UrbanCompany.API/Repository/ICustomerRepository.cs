using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        Customer UpdateCustomer(Customer customer);

        //void DeleteCustomer(string name);

        //
        Customer AddCustomer(Customer customer);
    }
}
