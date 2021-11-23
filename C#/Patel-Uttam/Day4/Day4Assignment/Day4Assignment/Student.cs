using System;
 

namespace Day4Assignment
{
    class Student
    {
        public short Age { get; }
        public string Name { get; }
        public DateTime DateOfJoining { get; }

        public Student(string name, short age, DateTime dateofJoin)
        {
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                    throw new NameException("name should only contain alphabets");
            }
            this.Name = name;
            if (age < 0)
            {
                throw new AgeException("Age cant be negative");
            }
            this.Age = age;

            if (dateofJoin < DateTime.Now)
            {
                throw new DateException("joinng date should not be in future");
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
