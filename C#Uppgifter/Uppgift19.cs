using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift19
{
    internal class Program
    {
        static int SumOfNumbers(int[] numbers)
        {
            return numbers.Sum();
        }
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 2, 3, 4, 5};
            int sum = SumOfNumbers(numbers);

            if (sum > -1)
            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add upp an empty array");
            }

            Console.WriteLine($"The length of the array is {numbers.Length}");

            if (numbers.Length < 0)
            {
                Console.WriteLine("Cannot add upp an empty array");
            }
            else
            {
                Console.WriteLine($"The total is: {sum}");
            }

            
        }
    }
}
