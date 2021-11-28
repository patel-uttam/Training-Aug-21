using Day17Assignment.Models;
using Day17Assignment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day17Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Report2Controller : ControllerBase
    {
        private readonly IReportRepository reportRepository;

        public Report2Controller(IReportRepository report)
        {
            reportRepository = report;
        }

        // GET: api/<Report2Controller>
        /*[Authorize]*/
        [HttpGet("{patient}")]
        public void Get(string patient)
        {
            reportRepository.Patient_Medicine(patient);
        }

    }
}
