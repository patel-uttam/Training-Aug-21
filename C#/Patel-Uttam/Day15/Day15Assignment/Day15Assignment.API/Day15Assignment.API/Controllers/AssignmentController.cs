using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15Assignment.API.Models;
using Day15Assignment.API.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day15Assignment.API.Controllers
{
    [ApiController]
    [Route("api/emps/{EmpID}/child/assignments")]
    
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentRepository assignmentRepository;

        public AssignmentController(IAssignmentRepository _assignmentRepository)
        {
            assignmentRepository = _assignmentRepository;
        }

        // GET: api/<AssignmentController>
        [HttpGet]
        
        public IEnumerable<Assignment> Get(int id)
        {
 
                return assignmentRepository.GetAllAssignment(id);

        }

        // GET api/<AssignmentController>/5
        [HttpGet("{id}")]
        public Assignment Get(int empid , int ass_id)
        {
            return assignmentRepository.GetAssignment(empid,ass_id);
        }

/*        // POST api/<AssignmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }*/

        // PUT api/<AssignmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Assignment assignment)
        {
            assignmentRepository.UpdateAssignment(assignment);
        }

/*        // DELETE api/<AssignmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
