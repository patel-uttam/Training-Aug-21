using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;
using UrbanCompany.API.Repository;
using UrbanCompany.API.Authentication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanCompany.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customer_repository;

        public CustomerController(ICustomerRepository repository)
        {
            customer_repository = repository;
        }



        // GET: api/<CustomerController>
        [Authorize(Roles =Roles.User)]
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customer_repository.GetCustomers();
            
        }

        // GET api/<CustomerController>/5
        [Authorize(Roles = Roles.User)]
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return customer_repository.GetCustomer(id);
        }

        /*        // POST api/<CustomerController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }*/

        // PUT api/<CustomerController>/5
        [Authorize(Roles = Roles.User)]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {

            if(customer.CustomerId == id)
            {
                customer_repository.UpdateCustomer(customer);
            }
        }

/*        // DELETE api/<CustomerController>/5
        [Authorize(Roles = Roles.User)]
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            customer_repository.DeleteCustomer(name);
        }*/
    }
}
