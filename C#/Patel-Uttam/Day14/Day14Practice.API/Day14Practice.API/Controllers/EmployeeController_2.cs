using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14Practice.API.Modals;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day14Practice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController_2 : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController_2(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/<EmployeeController_2>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAllEmployees();
        }

        // GET api/<EmployeeController_2>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeRepository.GetEmployee(id);
        }

        // POST api/<EmployeeController_2>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        // PUT api/<EmployeeController_2>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            if(id == employee.EmployeeId)
            {
                _employeeRepository.UpdateEmployee(employee);
            }
        }

        // DELETE api/<EmployeeController_2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }
    }
}
