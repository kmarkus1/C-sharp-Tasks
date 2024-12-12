using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift26
{
    public class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            double num1 = Convert.ToDouble(numerator);
            double num2 = Convert.ToDouble(denominator);
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Cannot divide by 0");
                return 0.0;
            }
            else
            {
                return num1 / num2;
            }
            //The try catch doesn't work since dividing a double by 0 doesn't give an error
            /* try
             {
                 double num1 = Convert.ToDouble(numerator);
                 double num2 = Convert.ToDouble(denominator);
                 double answer = num1 / num2;
                 return answer;
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Cannot divide by 0");
                 return 0.0; 
             }
            */
        }
        public int ParseInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter numertaor: ");
            string numertaor = Console.ReadLine();

            Console.Write("Enter denominator: ");
            string denominator = Console.ReadLine();

            int numertaorAsInt = calculator.ParseInput(numertaor);
            int denominatorAsInt = calculator.ParseInput(denominator);
            double result = calculator.Divide(numertaorAsInt, denominatorAsInt);

            if (result != 0)
            {
                Console.WriteLine($"Result: {result}");
            }
            

            

        }
    }
}
