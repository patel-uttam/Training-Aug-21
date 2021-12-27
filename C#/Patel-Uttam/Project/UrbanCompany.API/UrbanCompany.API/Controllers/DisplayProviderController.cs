using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Repository;
using UrbanCompany.API.Models;
using UrbanCompany.API.Authentication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanCompany.API.Controllers
{
    [Route("api/filter_providers")]
    [ApiController]
    public class DisplayProviderController : ControllerBase
    {
        private readonly IProviderRepository providerRepository;

        public DisplayProviderController(IProviderRepository repository)
        {
            providerRepository = repository;
        }
        // GET: api/<DisplayProviderController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<DisplayProviderController>/5

        [HttpGet("{name}")]
        public IEnumerable<Provider> Get(string name)
        {
            return providerRepository.GetProviderByService(name);
        }


/*        // POST api/<DisplayProviderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DisplayProviderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DisplayProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
