using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for a number and store it as a string variable
            Console.Write("Enter a number: ");
            string numberAsString = Console.ReadLine();

            try
            {
                //Try to convert user input to int
                int number = Convert.ToInt32(numberAsString);

                //if-else block to check if number is positive, negative or 0
                if (number > 0)
                {
                    Console.WriteLine("The number is positive");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative");
                }
                else
                {
                    Console.WriteLine("The number is 0");
                }
            }
            catch //if userinput couldn't be converted to int print error message
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
