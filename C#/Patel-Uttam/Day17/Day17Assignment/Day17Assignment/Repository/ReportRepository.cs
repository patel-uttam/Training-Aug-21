using Day17Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Day17Assignment.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly HospitalDBContext dBContext;

        public ReportRepository(HospitalDBContext  context)
        {
            dBContext = context;
        }

        public void Doctor_to_Patient(string doctor)
        {
              Console.WriteLine(dBContext.Treatments.FromSqlRaw($"Display_doctor_assign_to_patient {doctor}"));
        }

        public void Patient_Medicine(string patient)
        {
             Console.WriteLine(dBContext.DrugTimes.FromSqlRaw($"Patient_medicine_list {patient}"));
        }

        public void Summary(Treatment treatment)
        {
            Console.WriteLine(dBContext.Treatments.Where(t => t.Patient == treatment.Patient && t.Doctor == treatment.Doctor).Include(t => t.DoctorNavigation).Include(t => t.PatientNavigation));
        }
    }
}
