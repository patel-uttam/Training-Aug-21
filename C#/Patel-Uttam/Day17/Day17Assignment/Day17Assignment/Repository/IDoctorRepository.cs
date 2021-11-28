using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17Assignment.Models;

namespace Day17Assignment.Repository
{
    public interface IDoctorRepository
    {
        public IEnumerable<Doctor> GetDoctors();
        public Doctor GetDoctor(int id);
        public Doctor InsertDoctor(Doctor doctor);
        public Doctor UpdateDoctor(Doctor doctor);
        public Doctor DeleteDoctor(int id);
    }
}
