using System;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------");
            var person_ = new Person("Uttam", "Patel", "asd@123.com", new DateTime(2000, 01, 17));

            Console.WriteLine("FirstName : "+$"{person_.FirstName}" + "LastName : "+$"\n{person_.LastName}"+"Email : "+$"\n{person_.Email}" + "DateOfBirth : "+$"\n{person_.DOB}\n");

            person_.Adult();
            person_.BirthDay();
            person_.ChineseSign();
            person_.SunSign();
            person_.ScreenName();

            Console.WriteLine("---------------------------");

            //

            Console.WriteLine("---------------------------");
            var person = new Person("Uttam", "Patel", new DateTime(2003, 11, 27));
            person_.Adult();
            person_.BirthDay();
            person_.ChineseSign();
            person_.SunSign();
            person_.ScreenName();
            Console.WriteLine("---------------------------");

        }
    }


    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DateTime DOB { get; set; }



        public Person(string firstName, string lastName, string email, DateTime DOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = DOB;


        }

        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;

        }

        public Person(string firstName, string lastName, DateTime DOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = DOB;
        }


        public void Adult()
        {
            if (this.DOB.Year + 18 < DateTime.Now.Year)
            {
                Console.WriteLine(this.FirstName + ' ' + this.LastName + " is Adult");
            }
            else
            {
                Console.WriteLine(this.FirstName + ' ' + this.LastName + " is Not Adult");
            }
        }

        public void SunSign()
        {
            if (this.DOB.Month == 12)
            {

                if (this.DOB.Day < 22)
                    Console.WriteLine("Sagittarius");
                else
                    Console.WriteLine("capricorn");
            }

            else if (this.DOB.Month == 1)
            {
                if (this.DOB.Day < 20)

                    Console.WriteLine("Capricorn");
                else
                    Console.WriteLine("aquarius");
            }

            else if (this.DOB.Month == 2)
            {
                if (this.DOB.Day < 19)
                    Console.WriteLine("Aquarius");
                else
                    Console.WriteLine("pisces");
            }

            else if (this.DOB.Month == 3)
            {
                if (this.DOB.Day < 21)
                    Console.WriteLine("Pisces");
                else
                    Console.WriteLine("aries");
            }
            else if (this.DOB.Month == 4)
            {
                if (this.DOB.Day < 20)
                    Console.WriteLine("Aries");
                else
                    Console.WriteLine("taurus");
            }

            else if (this.DOB.Month == 5)
            {
                if (this.DOB.Day < 21)
                    Console.WriteLine("Taurus");
                else
                    Console.WriteLine("gemini");
            }

            else if (this.DOB.Month == 6)
            {
                if (this.DOB.Day < 21)
                    Console.WriteLine("Gemini");
                else
                    Console.WriteLine("cancer");
            }

            else if (this.DOB.Month == 7)
            {
                if (this.DOB.Day < 23)
                    Console.WriteLine("Cancer");
                else
                    Console.WriteLine("leo");
            }

            else if (this.DOB.Month == 8)
            {
                if (this.DOB.Day < 23)
                    Console.WriteLine("Leo");
                else
                    Console.WriteLine("virgo");
            }

            else if (this.DOB.Month == 9)
            {
                if (this.DOB.Day < 23)
                    Console.WriteLine("Virgo");
                else
                    Console.WriteLine("libra");
            }

            else if (this.DOB.Month == 10)
            {
                if (this.DOB.Day < 23)
                    Console.WriteLine("Libra");
                else
                    Console.WriteLine("scorpio");
            }

            else if (this.DOB.Month == 11)
            {
                if (this.DOB.Day < 22)
                    Console.WriteLine("scorpio");
                else
                    Console.WriteLine("sagittarius");
            }
        }

        public void ChineseSign()
        {
            switch ((this.DOB.Year - 4) % 12)
            {
                case 0:
                    Console.Write("Rat");
                    break;
                case 1:
                    Console.WriteLine("Ox");
                    break;
                case 2:
                    Console.WriteLine("Tiger");
                    break;
                case 3:
                    Console.WriteLine("Rabbit");
                    break;
                case 4:
                    Console.WriteLine("Dragon");
                    break;
                case 5:
                    Console.WriteLine("Snake");
                    break;
                case 6:
                    Console.WriteLine("Horse");
                    break;
                case 7:
                    Console.WriteLine("Goat");
                    break;
                case 8:
                    Console.WriteLine("Monkey");
                    break;
                case 9:
                    Console.WriteLine("Rooster");
                    break;
                case 10:
                    Console.WriteLine("Dog");
                    break;
                case 11:
                    Console.WriteLine("Pig");
                    break;
            }
        }

        public void BirthDay()
        {
            if (this.DOB.Year == DateTime.Now.Year && this.DOB.Month == DateTime.Now.Month && this.DOB.Date == DateTime.Now.Date)
            {
                Console.WriteLine("Toyday is Birthday of : " + this.FirstName + ' ' + this.LastName);
            }
            else
            {
                Console.WriteLine("Today is not Birthday");
            }
        }

        public void ScreenName()
        {
            Console.WriteLine(this.FirstName + "_" + DOB.Month.ToString() + "_" + DOB.Year.ToString());
        }

    }
}

