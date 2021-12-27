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
    public class ProviderController : ControllerBase
    {
        private readonly IProviderRepository provider_repocsitory;

        public ProviderController(IProviderRepository repository)
        {
            provider_repocsitory = repository;
        }



        // GET: api/<CustomerController>
        [Authorize(Roles = Roles.Provider)]
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            return provider_repocsitory.GetProviders();

        }

        // GET api/<CustomerController>/5
        [Authorize(Roles = Roles.Provider)]
        [HttpGet("{name}")]
        public Provider Get(int id)
        {
            return provider_repocsitory.GetProvider(id);
        }

        /*        // POST api/<CustomerController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }*/

        // PUT api/<CustomerController>/5
        [Authorize(Roles = Roles.Provider)]
        [HttpPut("{name}")]
        public void Put(string name, [FromBody] Provider provider)
        {
            if (provider.ProviderName == name)
            {
                provider_repocsitory.UpdateProvider(provider);
            }
        }

/*        // DELETE api/<CustomerController>/5
        [Authorize(Roles = Roles.Provider)]
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            provider_repocsitory.DeleteProvider(name);
        }*/
    }
}
