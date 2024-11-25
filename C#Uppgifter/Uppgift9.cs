using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 2;
            int num4 = 0;
            bool isTrue = true;

            Console.WriteLine(isTrue && (num1 > num3) && (num2 < num4));
            Console.WriteLine(isTrue && (num1 < num3) || (num2 > num4));
            Console.WriteLine(!isTrue);
            Console.WriteLine();

            Console.WriteLine(num1 > num3);
            Console.WriteLine(num2 < num4);
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num2 != num3);
            Console.WriteLine();

            bool expression1 = (num1 > num3 && num2 < num4);
            bool expression2 = (num1 < num3 || num2 > num4);

            Console.WriteLine(expression1);
            Console.WriteLine(expression2);

        }
    }
}
