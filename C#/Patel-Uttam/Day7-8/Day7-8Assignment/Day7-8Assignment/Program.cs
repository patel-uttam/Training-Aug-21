using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7_8Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<eloyee> eloyees = new List<eloyee>()
            
            {
                new eloyee(){ ID=1,FirstName="John",LastName="Abraham",Salary=1000000,JoiningDate=new DateTime(2013,1,1),Deparment="Banking"},
                new eloyee(){ ID=2,FirstName="Michael",LastName="Clarke",Salary=800000,JoiningDate=new DateTime(),Deparment="Insurance" },
                new eloyee(){ ID=3,FirstName="oy",LastName="Thomas",Salary=700000,JoiningDate=new DateTime() ,Deparment="Insurance"},
                new eloyee(){ ID=4,FirstName="Tom",LastName="Jose",Salary=600000,JoiningDate=new DateTime() ,Deparment="Banking"},
                new eloyee(){ ID=4,FirstName="TestName2",LastName="Lname%",Salary=600000,JoiningDate=new DateTime(2013,1,1) ,Deparment="Services"}

            };

            List<Incentive> incentives = new List<Incentive>()

            {

                new Incentive(){ ID=1,IncentiveAmount=5000,IncentiveDate=new DateTime(2013,02,02)},

                new Incentive(){ ID=2,IncentiveAmount=10000,IncentiveDate=new DateTime(2013,02,4)},

                new Incentive(){ ID=1,IncentiveAmount=6000,IncentiveDate=new DateTime(2012,01,5)},

                new Incentive(){ ID=2,IncentiveAmount=3000,IncentiveDate=new DateTime(2012,01,5)}

            };

            // get eloyee with 'john'

            var search_eloyee = eloyees.FirstOrDefault(e => e.FirstName == "John");

            Console.WriteLine("eloyee with name 'john' : "+search_eloyee.FirstName);

            // Get FIRSTNAME,LASTNAMe from eloyees object.
            var first_last_names = from e in eloyees select new { e.FirstName , e.LastName};

            foreach (var name in first_last_names)
            {
                Console.WriteLine(name.FirstName+' '+name.LastName);
            }

            //Get Firstname and Incentive amount of eloyees.
            var first_name_incentive = from e in eloyees join inc in incentives on e.ID equals inc.ID select new {e.FirstName,inc.IncentiveAmount };
            foreach (var name_incentive in first_name_incentive)
            {
                Console.WriteLine("Incentive Amount for "+ name_incentive.FirstName+" is : "+name_incentive.IncentiveAmount);
            }


            // Department max salary

            var max_dept_salary = from e in eloyees group e by e.Deparment into dept let max_salary = dept.Max(s => s.Salary) select new { dept.Key, dept.First(s => s.Salary == max_salary).Salary }; 

            foreach (var dept_salary in max_dept_salary)
            {
                Console.WriteLine(dept_salary.Key +" has max salary : "+dept_salary.Salary);
            }


            //Select department, total salary where TotalSalary > 800000

            var total_salary = eloyees.GroupBy(e => e.Deparment)
                .OrderByDescending(e => e.Sum(s => s.Salary))
                .Where(e => e.Sum(s => s.Salary) > 800000)
                .Select(e => new { e.Key, TotalSalary = e.Sum(e => e.Salary) });

            foreach (var i in total_salary)
            {
                Console.WriteLine(i.Key +' with total salary : '+i.TotalSalary);
            }
            Console.ReadKey();
        }


    }


    // class eloyee
    public class eloyee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Deparment { get; set; }
    }





    // Incentive

    public class Incentive
    {
        public int ID { get; set; }
        public double IncentiveAmount { get; set; }
        public DateTime IncentiveDate { get; set; }
    }
}
