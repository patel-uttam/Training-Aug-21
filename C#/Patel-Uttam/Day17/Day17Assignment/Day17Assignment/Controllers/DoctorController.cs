using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17Assignment.Repository;
using Day17Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Day17Assignment.Authentication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day17Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository idoctorepo;

        public DoctorController(IDoctorRepository idoctorRepository)
        {
            idoctorepo = idoctorRepository;
        }
        // GET: api/<DoctorController>
        [Authorize]
        [HttpGet]
        [Route("Search-Doctor")]
        public IEnumerable<Doctor> Search_Doctor()
        {
            return idoctorepo.GetDoctors();

        }

        // GET api/<DoctorController>/5
        [Authorize]
        [Route("Search-Doctor")]
        [HttpGet("Search-Doctor/{id}")]
        public Doctor Search_Doctor(int id)
        {
            return idoctorepo.GetDoctor(id);
        }

        // POST api/<DoctorController>
        [Authorize(Roles =AuthenticationRole.Admin)]
        [Route("Add-doctor")]
        [HttpPost]
        public void Add_Doctor([FromBody] Doctor  doctor)
        {
            idoctorepo.InsertDoctor(doctor);
        }

        // PUT api/<DoctorController>/5
        [Authorize(Roles = AuthenticationRole.Admin)]
        [Route("Update-doctor")]
        [HttpPut("{id}")]
        public void Update_Doctor(int id, [FromBody] Doctor doctor)
        {
            if(id == doctor.DoctorId)
            {
                idoctorepo.UpdateDoctor(doctor);
            }
        }

        // DELETE api/<DoctorController>/5
        [Authorize(Roles = AuthenticationRole.Admin)]
        [Route("Delete-Doctor")]
        [HttpDelete("{id}")]
        public void Delete_Doctor(int id)
        {
            idoctorepo.DeleteDoctor(id);
        }
    }
}
