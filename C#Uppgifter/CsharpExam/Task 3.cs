using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string array
            string[] names = { "Bob", "Steve", "Nina" };
            //int array
            int[] numbers = { 5, 57, 87, 1, 150, 32, 14 };

            //foreach loop to loop trough the names array and print a message
            foreach (string name in names)
            {
                Console.WriteLine($"Goodbye {name}");
            }
            //Sort the numbers array in ascending order
            Array.Sort( numbers );

            //Reduce the lenght of array by 1, removing the last element in the array
            numbers = numbers.Take(numbers.Count() - 1).ToArray();

            //Loop trough array and print all numbers
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
