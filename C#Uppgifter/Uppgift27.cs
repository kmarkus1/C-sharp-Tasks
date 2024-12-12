using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift27
{
    class MathOperations
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Subtraction(int x, int y)
        {
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public double Division(int x, int y)
        {
            try
            {
                double num1 = x;
                double num2 = y;
                return num1 / num2;
            }
            catch
            {
                return 0;
            }
        }
        public double Power(int x, int y)
        {
            double num1 = x;
            double num2 = y;
            return Math.Pow(num1, num2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations ops = new MathOperations();

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Addition: {num1} + {num2} = {ops.Addition(num1, num2)}");

            Console.WriteLine($"Subtraction: {num1} - {num2} = {ops.Subtraction(num1, num2)}");

            Console.WriteLine($"Multiplication: {num1} * {num2} = {ops.Multiplication(num1, num2)}");

            if ( num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine($"Division: {num1} / {num2} = {ops.Division(num1, num2)}");
            }
            Console.WriteLine($"Power: {num1} ^ {num2} = {ops.Power(num1, num2)}");
        }
    }
}
