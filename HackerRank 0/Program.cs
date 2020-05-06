using System;

namespace EX1_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine("Hello, World.");
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Welcome to 30 Days of Code!");
            }
            else
            {
                Console.WriteLine(inputString);
            }


        }
    }
}
