using System;
using System.Collections.Generic;

namespace Day5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobike> customer_record = new List<Mobike>();
            Boolean loop_value = true;
            while (loop_value)
            {
                Console.WriteLine('\n');
                Console.WriteLine("Welcome Rambo Rental Bikes");
                Console.WriteLine("Enter 1 for insert record"+"\n"+"Enter 2 for Removal of record"+"\n"+"Enter 3 For Search record"+"\n"+"Enter 4 for update record"+"\n"+"Enter 0 to Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertRecord(customer_record);
                        break;
                    case 2:
                        RemoveRecord(customer_record);
                        break;

                    int bike_number;

                    case 3:
                        Console.WriteLine("Enter BikeNumber you want search");

                        bike_number = Convert.ToInt32(Console.ReadLine());

                        Mobike result = SearchRecord(customer_record, bike_number);
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
                        Console.WriteLine("Enter BikeNumber you want update");
                         bike_number = Convert.ToInt32(Console.ReadLine());

                        UpdateRecord(customer_record, bike_number);
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

        private static void UpdateRecord(List<Mobike> customer_record, int BikeNumber)
        {
            Mobike Update_record = new Mobike();
            Update_record = SearchRecord(customer_record, BikeNumber);
            if (Update_record == null)
            {
                Console.WriteLine("No one rent this Bike yet.");

            }
            else
            {
                Console.WriteLine("Enter 1 for Update phone number \n Enter 2 for change days of rent");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter phone Number: ");
                        Update_record.PhoneNumber = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter days: ");
                        Update_record.Days = Convert.ToInt32(Console.ReadLine());
                        Update_record.Compute();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            Console.WriteLine('\n'+"Updated record ");
            foreach (var rec in customer_record)
            {
                Update_record.Compute();
                Update_record.Display();
                Update_record.Display();
            }


        }

        private static Mobike SearchRecord(List<Mobike> customer_record, int BikeNumber)
        {

            foreach (var customer in customer_record)
            {
                if (customer.BikeNumber == BikeNumber)
                {
                    return customer;
                }
            }

            return null;
        }

        private static void RemoveRecord(List<Mobike> customer_record)
        {
            Console.WriteLine("Enter BikeNumber of want remove: ");
            int BikeNumber = Convert.ToInt32(Console.ReadLine());

            customer_record.Remove(SearchRecord(customer_record, BikeNumber));

            foreach (var record in customer_record)
            {
                record.Display();
            }
        }

        private static void InsertRecord(List<Mobike> customer_record)
        {
            var RentToCustomer = new Mobike();

            Console.WriteLine("Bike Number : ");
            RentToCustomer.BikeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("customer name : ");
            RentToCustomer.Name = Console.ReadLine();
            Console.WriteLine("phone number : ");
            RentToCustomer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("days for rent a bike : ");
            RentToCustomer.Days = Convert.ToInt32(Console.ReadLine());
            RentToCustomer.Compute();
            RentToCustomer.Display();
            customer_record.Add(RentToCustomer);

        }

    }


    // mobike 

    class Mobike
    {
        public int BikeNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public decimal Charge { get; set; }


        public void Input(int bikeNumber, string phoneNumber, string name, int days)
        {
            BikeNumber = bikeNumber;
            PhoneNumber = phoneNumber;
            Name = name;
            Days = days;
            Compute();
        }

        public void Compute()
        {
            int cost = 0;
            for (int i = 0; i < this.Days; i++)
            {
                if (i < 5)
                {
                    cost += 500;
                }
                else if (i < 10)
                {
                    cost += 400;
                }
                else
                {
                    cost += 200;
                }
            }

            Charge = cost;
        }

        public void Display()
        {
            Console.WriteLine("1." + "Bikenumber :" + " " + BikeNumber + "\t\t" + "2." + "Customer :" + " " + Name + "\t\t" + "3." + "Phonenumber :" + " " + PhoneNumber + "\t\t" + "4." + "On Rent for  :" + " " + Days + "Days" + "\t\t" + "5." + "Total Charge :" + " " + Charge + "\t\t" + "\n\n");
        }
    }
}
