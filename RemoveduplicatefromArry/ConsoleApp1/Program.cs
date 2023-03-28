using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string inpts= Console.ReadLine();

            int[] nums = inpts.TrimEnd().Split(',').Select(x=>Int32.Parse( x)).ToArray<int>();

            int i = 0, k = 1, distinct = 0;

            while (i < nums.Length && k < nums.Length)
            {
                if (nums[i] == nums[k])
                {
                    k++;
                }
                else
                {
                    i++;
                    nums[i] = nums[k];
                    k++;
                    distinct++;
                }
            }

            Console.Write($"{distinct} ");
            for(int j = 0; j < nums.Length; j++)
            {
                if(j<= distinct) 
                {
                    Console.Write($"{nums[j]}");
                }
                else
                {
                    Console.Write($"_");
                }
                if (j < nums.Length - 1)
                {
                    Console.Write($",");
                }
            }
            Console.WriteLine();
        }

       
    }

   
}
