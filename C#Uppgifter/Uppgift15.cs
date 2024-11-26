using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, 30, 25 };
            // Use .Max() to find max value in array
            int max = numbers.Max();

           /*for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
           */
            Console.WriteLine($"The maximum value in the array is: {max}");



            Console.ReadLine();
        }
    }
}
