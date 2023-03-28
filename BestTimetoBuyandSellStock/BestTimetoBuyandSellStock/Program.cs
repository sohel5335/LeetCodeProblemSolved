using System;
using System.Linq;

namespace BestTimetoBuyandSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int [] pricess = input.TrimEnd().Split(',').Select(x => Int32.Parse(x)).ToArray<int>();

            int profit = 0;
            for (int i = 0, j = 1; j < pricess.Length; i++, j++)
            {
                if (pricess[i] < pricess[j])
                {
                    profit += pricess[j] - pricess[i];

                }
            }

            Console.WriteLine(profit);
            Console.ReadLine();


        }
    }
}
