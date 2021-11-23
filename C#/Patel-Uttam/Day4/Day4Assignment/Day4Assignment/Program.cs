using System;

namespace Day4Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                DateTime datetime = DateTime.Now;
                DateTime datetime_added = datetime.AddDays(1);
                DateTime datetime_minused = datetime.AddDays(-1);                                                       

                var student_uttam = new Student("Uttam", 21, datetime_added);
                Console.WriteLine(student_uttam.Age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
