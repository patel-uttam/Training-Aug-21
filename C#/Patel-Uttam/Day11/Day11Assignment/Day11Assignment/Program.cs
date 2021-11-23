using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Day11Assignment.Models;

namespace Day11Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day11 Assignment");

            Console.WriteLine("Select Option for insert / update / delete doctor");
            bool while_flag = true;
            while(while_flag)
            {
                Console.WriteLine("Enter 1 for insert Doctor");
                Console.WriteLine("Enter 2 for update Doctor");
                Console.WriteLine("Enter 3 for delete Doctor");
                Console.WriteLine("Enter 4 to exit");
                var choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        using(HospitalDBContext hospitalcontext = new HospitalDBContext())
                        {
                            Doctor doctor = new Doctor();

                            Console.WriteLine("Enter Doctor Name :");
                            doctor.DoctorName = Console.ReadLine();
                            Console.WriteLine("Enter Doctor's Department " + "\t\t"+ "1 for Emergency"+"\t"+ "2 for OPD" + "\t"+ "3 for ICU" + "\t"+ "4 for Cardiology" + "\t");
                            doctor.Department = int.Parse(Console.ReadLine());

                            hospitalcontext.Doctors.Add(doctor);
                            hospitalcontext.SaveChanges();
                            Console.WriteLine("Doctor Added");
                        }   

                        break;

                    case 2:
                        using (HospitalDBContext hospitalcontext = new HospitalDBContext())
                        {
                            Doctor doctor = new Doctor();
                            Console.WriteLine("Enter ID of Doctor to Change Name");
                            int doctor_id = int.Parse(Console.ReadLine());
                            
                            doctor = hospitalcontext.Doctors.Find(doctor_id);
                            doctor.DoctorName = "Jyanti Patel";
                            var doctor_department = doctor.Department;
                            Console.WriteLine(doctor.DoctorId + "  "+ doctor_department);
                            doctor.Department = doctor_department;
                            hospitalcontext.Doctors.Update(doctor);
                            hospitalcontext.SaveChanges();
                            Console.WriteLine("Updated");
                        }
                        break;

                    case 3:
                        using (HospitalDBContext hospitalcontext = new HospitalDBContext())
                        {
                            Doctor doctor = new Doctor();

                            Console.WriteLine("Enter Doctor ID :");
                            doctor.DoctorId= int.Parse(Console.ReadLine());
                            hospitalcontext.Doctors.RemoveRange(doctor);
                            hospitalcontext.SaveChanges();
                            Console.WriteLine("Doctor removed");
                            
                        }
                        break;

                    case 4:
                        while_flag = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
