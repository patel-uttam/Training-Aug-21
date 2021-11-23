using System;
using System.Collections.Generic;

namespace Day5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobike> customers = new List<Mobike>();
            Boolean loop_value = true;
            while (loop_value)
            {
                Console.WriteLine("Enter 1 for insert record"+"\n"+"Enter 2 for Removal of record"+"\n"+"Enter 3 For Search record"+"\n"+"Enter 4 for update record"+"\n"+"Enter 0 to Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertRecord(customers);
                        break;
                    case 2:
                        RemoveRecord(customers);
                        break;
                    case 3:
                        Console.WriteLine("Enter Record BikeNumber u want search");
                        Mobike result = SearchRecord(customers, Convert.ToInt32(Console.ReadLine()));
                        if (result == null)
                        {
                            Console.WriteLine("Record doesnt exist");
                        }
                        else
                        {
                            result.Display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Record BikeNumber u want update");
                        UpdateRecord(customers, Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 0:
                        loop_value = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            }


            Console.ReadKey();
        }

        private static void UpdateRecord(List<Mobike> customers, int bikeNumber)
        {
            Mobike record = new Mobike();
            record = SearchRecord(customers, bikeNumber);
            if (record == null)
            {
                Console.WriteLine("Invalid bikeNumber\nRecord does not exist");

            }
            else
            {
                Console.WriteLine("Enter 1 for name Update\n 2 for phone number \n 3 for days");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name: ");
                        record.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter phone Number: ");
                        record.PhoneNumber = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter days: ");
                        record.Days = Convert.ToInt32(Console.ReadLine());
                        record.Compute();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            foreach (var rec in customers)
            {
                record.Display();
            }


        }

        private static Mobike SearchRecord(List<Mobike> customers, int bikeNumber)
        {

            foreach (var customer in customers)
            {
                if (customer.BikeNumber == bikeNumber)
                {
                    return customer;
                }
            }

            return null;
        }

        private static void RemoveRecord(List<Mobike> customers)
        {
            Console.WriteLine("Enter BikeNumber of record You want remove: ");
            int bikeNumber = Convert.ToInt32(Console.ReadLine());

            customers.Remove(SearchRecord(customers, bikeNumber));

            foreach (var record in customers)
            {
                record.Display();
            }
        }

        private static void InsertRecord(List<Mobike> customers)
        {
            var newRecord = new Mobike();

            Console.WriteLine("Enter Bike Number");
            newRecord.BikeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            newRecord.Name = Console.ReadLine();
            Console.WriteLine("Enter customer phone number: ");
            newRecord.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter number of days for bikerent: ");
            newRecord.Days = Convert.ToInt32(Console.ReadLine());
            newRecord.Compute();
            newRecord.Display();
            customers.Add(newRecord);

        }

    }
}
