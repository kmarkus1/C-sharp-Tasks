using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            //Saves input to a variable and converts it to int
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a double: ");
            //Save input and convert to double
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a float: ");
            //Save input and convert to float
            float num3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter a string: ");
            //Save input in a variable
            string str = Console.ReadLine();
            //Write the saved variables to the console
            Console.WriteLine($"{num}, {num2}, {num3}, {str}");

            Console.WriteLine("Int stands for integer wich is a whole number.");
            Console.WriteLine("Float is a fractional number. Float can store 6-7 decimal digits.");
            Console.WriteLine("Double is a fractional number that can store up to 15 decimal digits.");
            Console.WriteLine("String is a string of characters, can contain any characters (like letters, numbers, special characters)");
        }
    }
}
