using Day17Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17Assignment.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
         private HospitalDBContext hospitalDBContext;
        public DoctorRepository(HospitalDBContext _hospitalDBContext)
        {
            hospitalDBContext = _hospitalDBContext;
        }

        public Doctor GetDoctor(int id)
        {
            return hospitalDBContext.Doctors.FirstOrDefault(d => d.DoctorId == id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return hospitalDBContext.Doctors;
        }

        public Doctor InsertDoctor(Doctor doctor)
        {
            hospitalDBContext.Doctors.Add(doctor);
            hospitalDBContext.SaveChanges();
            return doctor;
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            var updateDoctor = hospitalDBContext.Doctors.Attach(doctor);
            updateDoctor.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            hospitalDBContext.SaveChanges();
            return doctor;
        }

        public Doctor DeleteDoctor(int id)
        {
            var deleteDoctor = hospitalDBContext.Doctors.FirstOrDefault(d=>d.DoctorId == id);
            hospitalDBContext.Doctors.Remove(deleteDoctor);
            hospitalDBContext.SaveChanges();
            return deleteDoctor;
        }
    }
}
