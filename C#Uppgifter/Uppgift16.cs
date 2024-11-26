using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 45, 12, 78, 34, 89, 23 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            Array.Sort( numbers );

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            Array.Reverse( numbers );

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            numbers = numbers.Where(val => val != 78).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
            bool foundNumber = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 34)
                {
                    foundNumber = true;
                    Console.WriteLine($"The number 34 is at index [{i}]");
                }
                
            }

            if ( !foundNumber )
            {
                Console.WriteLine("Could not find number 34");
            }
        }
    }
}
