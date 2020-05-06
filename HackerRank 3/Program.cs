using System;

namespace HackerRank_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            

            if (N %2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N %2 == 0 && N > 1 && N < 6)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N %2 == 0 && N > 5 && N < 21 )
            {
                Console.WriteLine("Weird");
            }
            else if (N %2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
