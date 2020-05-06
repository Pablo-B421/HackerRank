using System;

namespace HackerRank_Day_2
{
    class Program
    {

        static void Solve(double mealCost, int tipPercent, int taxPercent)
        {
            double tip = mealCost * (Convert.ToDouble(tipPercent) / 100);
           

            double tax = mealCost * (Convert.ToDouble(taxPercent) / 100);
            

            double totalCost = mealCost + tip + tax;

            Console.WriteLine(Convert.ToInt32(totalCost));

           
        }
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());

            int tipPercent = Convert.ToInt32(Console.ReadLine());

            int taxPercent = Convert.ToInt32(Console.ReadLine());

            Solve(mealCost, tipPercent, taxPercent);


        }
    }
}
