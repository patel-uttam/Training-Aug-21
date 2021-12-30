using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Authentication;
using UrbanCompany.API.Models;
using UrbanCompany.API.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanCompany.API.Controllers

{
    [Route("api/services")]
    [ApiController]
    public class DisplaySeviceController : ControllerBase
    {
        private readonly IDisplayServicesRepository servicesRepository;

        public DisplaySeviceController(IDisplayServicesRepository display)
        {
            servicesRepository = display;
        }

        // GET: api/<DisplaySeviceController>
        [Authorize(Roles =Roles.User)]
        [HttpGet]
        public IEnumerable<ServicesCategory> Get()
        {
            return servicesRepository.Get_Service_Category();
        }

        // GET api/<DisplaySeviceController>/5
        [Authorize(Roles = Roles.User)]
        [HttpGet("{name}")]
        public IEnumerable<SubService> Get(string name)
        {
            return servicesRepository.Get_Sub_Service(name);
        }


/*        [Authorize(Roles = Roles.User)]
        [HttpGet("provider/{name}")]

        public IEnumerable<Provider> Get(string name)
        {
            return servicesRepository.Get_Provider_By_Service(name);
        }*/
    }
}
