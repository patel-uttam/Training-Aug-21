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
                Console.WriteLine("StudentName :"+student_uttam.Name + "\t-\t" + "StudentAge :" + student_uttam.Age + "\t-\t" + "StudentDOJ :" + student_uttam.DateOfJoining);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    class Student
    {
        public int Age { get; }
        public string Name { get; }
        public DateTime DateOfJoining { get; }

        public Student(string name, short age, DateTime dateofJoin)
        {
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                    throw new NameException("name is not in correct format");
            }
            this.Name = name;
            if (age < 0)
            {
                throw new AgeException("Age is not in correct format");
            }
            this.Age = age;

            if (dateofJoin < DateTime.Now)
            {
                throw new DateException("joinng is not in correct format");
            }
            this.DateOfJoining = dateofJoin;
        }
    }

    public class AgeException : Exception
    {
        public AgeException(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class NameException : Exception
    {
        public NameException(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DateException : Exception
    {
        public DateException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
