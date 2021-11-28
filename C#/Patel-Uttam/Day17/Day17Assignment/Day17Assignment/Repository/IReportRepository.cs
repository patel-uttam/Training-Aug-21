using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17Assignment.Models;

namespace Day17Assignment.Repository
{
    public interface IReportRepository
    {
        public void Doctor_to_Patient(string doctor);

        public void Patient_Medicine(string patient);

        public void Summary(Treatment treatment);
    }
}
