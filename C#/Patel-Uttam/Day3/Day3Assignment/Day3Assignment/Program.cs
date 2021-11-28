using System;

namespace Day3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = null;
            Console.WriteLine("Enter 1 for part-time Employee and 2 full-time Employee");
            int EmployeeType = Convert.ToInt32(Console.ReadLine());
            switch (EmployeeType)
            {
                case 1:
                    PartTime partTime = new PartTime();
                    partTime.Get();
                    partTime.Salary();

                    break;
                case 2:
                    FullTime fullTime = new FullTime();
                    fullTime.Get();
                    fullTime.Salary();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }

    }


    // interface
    interface EmployeeInterface
    {
        void Get();
        void Salary();
        void Display();
    }


    // abstract
    abstract class Employee : EmployeeInterface
    {
        static int ID;
        string Name, Address, PanNumber;

        public virtual void Get()
        {
            ID++;
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
            Console.Write("Enetr pan Number: ");
            PanNumber = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID  {ID} Name is {Name} Address is {Address} PanNumber is {PanNumber} ");
        }


        public abstract void Salary();

    }

    class PartTime : Employee
    {
        int NoOfHours, TotalSales;
        float SalesPerHour;

        public override void Get()
        {
            base.Get();
            Console.Write("Eneter No. Of Hours: ");
            NoOfHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter TotalSales: ");
            TotalSales = Convert.ToInt32(Console.ReadLine());
            SalesPerHour = (float)TotalSales / NoOfHours;
            Display();
        }

        public override void Salary()
        {
            // 50rs for every hour and 500 for single sale
            Console.WriteLine($"The Salary of Employee is Rs{NoOfHours * 50 + SalesPerHour * 500}");
        }


    }

    class FullTime : Employee
    {
        decimal Basic, HRA, TA, DA;

        public override void Get()
        {
            base.Get();
            Console.Write("Eneter base pay: ");
            Basic = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Rent if Employee living in rental accomodation? (enter 0 if not)");
            HRA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter TA: ");
            TA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter DA: ");
            DA = Convert.ToDecimal(Console.ReadLine());
            Display();

        }

        public override void Salary()
        {
            Console.WriteLine($"total salary of the employee is {Basic + HRA + TA + DA}");
        }


    }
}
