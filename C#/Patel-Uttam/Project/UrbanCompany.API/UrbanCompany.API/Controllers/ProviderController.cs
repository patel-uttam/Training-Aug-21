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


        // Get Method to Get Collection Records of providers (Admin has Authority)

        [Authorize(Roles = Roles.Admin)]
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            return provider_repocsitory.GetProviders();

        }

        // GET Method to Get Customer Record 

        [Authorize(Roles = Roles.Provider)]
        [HttpGet("{name}")]
        public Provider Get(string name)
        {
            return provider_repocsitory.GetProvider(name);
        }

        [HttpGet("{id}/{city}")]
        public IEnumerable<Provider> Get(int id,string city)
        {
            return provider_repocsitory.GetProviderByCategory_City(id,city);
        }

        [HttpGet("category/{city}/{dist}")]
        public IEnumerable<string> Get(string city , string dist)
        {
            return provider_repocsitory.GetCategory(dist);
        }


        // Put Method to Update Provider Record

        [Authorize(Roles = Roles.Provider)]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Provider provider)
        {
            if (provider.ProviderId == id)
            {
                provider_repocsitory.UpdateProvider(provider);
            }
        }


    }
}
