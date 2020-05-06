using System;

namespace HackerRank_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //included in HackerRank Stub
        }
    }

    class Person
    {
        public int age;
        public Person (int initialAge)
        {
            bool notNegative = initialAge >= 0;

            if (notNegative == true)
            {
                age = initialAge;
            }
            else if (notNegative == false)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void yearPasses()
        {
            age++;
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age > 12 && age <18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

    }
}
