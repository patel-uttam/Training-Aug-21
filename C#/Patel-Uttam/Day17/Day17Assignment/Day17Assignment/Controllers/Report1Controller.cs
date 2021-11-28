using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17Assignment.Models;
using Day17Assignment.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day17Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Report1Controller : ControllerBase
    {
        private readonly IReportRepository reportRepository;

        public Report1Controller(IReportRepository report)
        {
            reportRepository = report;
        }

        // GET: api/<ReportsController>
        /*[Authorize]*/
        [HttpGet("{doctor}")]
        public void Get(string doctor)
        {
            reportRepository.Doctor_to_Patient(doctor);
        }

    }
}
