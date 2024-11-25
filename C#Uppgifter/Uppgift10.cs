using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 10;
            int num6 = 6;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num5 / num6);
            Console.WriteLine();

            Console.WriteLine(++num6); // 7
            Console.WriteLine(--num6); // 6
            Console.WriteLine(num6++); // prints 6 num6 = 7
            Console.WriteLine(num6--); // prints 7 num6 = 6
            
            Console.WriteLine();

            Console.WriteLine(num5 += 7); // 17
            Console.WriteLine(num5 -= 4); // 13
            Console.WriteLine(num5 *= 3); // 39
            Console.WriteLine(num5 /= 5); // 7
            Console.WriteLine(num5 %= 2); // 1

            Console.WriteLine(14 % 6);
        }
    }
}
