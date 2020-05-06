using System;

namespace HackerRank_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int myInt;
            double myDouble;
            string myString;

            myInt = Convert.ToInt32(Console.ReadLine());

            myDouble = Convert.ToDouble(Console.ReadLine());

            myString = Console.ReadLine();

            Console.WriteLine(i + myInt);

            Console.WriteLine("{0:N1}",Convert.ToDouble(d + myDouble));

            Console.WriteLine(s + myString);
        }
    }
}
// Declare second integer, double, and String variables.

// Read and save an integer, double, and String to your variables.

// Print the sum of both integer variables on a new line.

// Print the sum of the double variables on a new line.

// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
