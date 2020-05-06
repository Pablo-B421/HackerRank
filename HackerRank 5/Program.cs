using System;

namespace HackerRank_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 1 && n <21)
            {
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine($"{n} x {i + 1} = {n * (i + 1)}");


                }
            }

            
        }
    }
}
