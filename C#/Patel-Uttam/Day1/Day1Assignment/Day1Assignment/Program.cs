using System;
using System.Collections.Generic;


namespace Day1Assignment
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            //Declare sum,count variable
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter Start And End Number in which You want Add the Even number between This Two number");
            Console.WriteLine("Enter The Starting Number");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Ending Number");
            int Number2 = int.Parse(Console.ReadLine());

            for (int i = Number1; i <= Number2; i++)
            {
                //Check Number is divisible by 2 or not
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            Console.WriteLine("Total Even Number Between {0}To {1} is {2}", Number1, Number2, count);
            Console.WriteLine("Sum of All Even Number Between {0}To {1} is {2}", Number1, Number2, sum);


            /**/

            Assignment1 obj = new Assignment1();
            Console.WriteLine("Please Enter Your Name :");
            string Person_Name = Console.ReadLine();
            obj.Find_Vowel(Person_Name.ToLower());

            /**/
            Console.WriteLine("Enter The WeekDay Number: \n 0.Sunday,\n 1.Monday,\n 2.Tuesday,\n 3. Wednesday,\n 4. Thursday,\n 5. Friday,\n 6. Saturday");
            int Num = System.Int32.Parse(Console.ReadLine());
            WeekDay WeekNum = (WeekDay)Num;
            Console.WriteLine("Week Day Is :{0}", WeekNum);

            /**/

            string Name;
            string Address;
            string Grade = "", str = "";
            int Hindi, English, Maths, Total;

            Console.WriteLine("How Many Students Result You want to Make..?");
            int Student_Number = int.Parse(Console.ReadLine());

            Console.WriteLine("Student is {0}", Student_Number);

            //student array to store students_Result
            string[] student = new string[Student_Number];
            Console.WriteLine("Please Enter student Details");

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter {0} Student Name", i + 1);
                Name = Console.ReadLine();
                Console.WriteLine("Enter {0} Student Address", i + 1);
                Address = Console.ReadLine();
                Console.WriteLine("Enter {0} Student Hindi Marks", i + 1);
                Hindi = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter {0} Student English Marks", i + 1);
                English = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter {0} Student Maths Marks", i + 1);
                Maths = int.Parse(Console.ReadLine());
                Total = (Hindi + English + Maths) / 3;
                if (Total > 90)
                {
                    Grade = "A";
                }
                else if (Total > 75 && Total <= 90)
                {
                    Grade = "B";
                }
                else if (Total > 50 && Total <= 75)
                {
                    Grade = "C";
                }
                else if (Total > 33 && Total <= 50)
                {
                    Grade = "D";
                }
                else if (Total <= 33)
                {
                    Grade = "F";
                }
                student[i] = "  " + Name + "  " + Address + "  " + Hindi + "  " + English + "  " + Total + "  " + Grade + "  ";
            }
            Console.WriteLine("Student list is :\n");
            Console.WriteLine(str + "\n" + "  Name  Address  Hindi  English  Total  Grade  \n" + str);
            for (int i = 0; i < student.Length; i++)
            {

                Console.WriteLine(student[i]);
            }
            Console.WriteLine("\n\n");
            /**/

            int Age;
            Console.WriteLine("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());

            //Ternary operator use For age Check
            string result = (Age > 18) ? "You are eligible for vote" : "You are not eligible for vote";
            Console.WriteLine(result);
        }

        public void Find_Vowel(string Name)
        {
            int count = 0;
            string Vowel = "";
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'a' || Name[i] == 'e' || Name[i] == 'i' || Name[i] == 'o' || Name[i] == 'u')
                {
                    Vowel = Vowel + Name[i] + ",";
                    count++;
                }
            }
            Console.WriteLine("Total Vowel in {0} is : {1}", Name, count);
            Console.WriteLine("Vowel in {0} is : {1}", Name, Vowel);
        }

        /**/

        enum WeekDay { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    }
}