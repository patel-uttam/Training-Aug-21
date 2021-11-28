using Day17Assignment.Models;
using Day17Assignment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Report3Controller : ControllerBase
    {
        private readonly IReportRepository reportRepository;

        public Report3Controller(IReportRepository report)
        {
            reportRepository = report;
        }

        // GET: api/<Report2Controller>
        /*[Authorize]*/
        [HttpGet("{summary}")]
        public void Get(Treatment treatment)
        {
            reportRepository.Summary(treatment);
        }

    }
}
