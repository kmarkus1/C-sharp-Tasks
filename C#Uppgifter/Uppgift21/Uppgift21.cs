using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 50)
            {
                Console.WriteLine("Over 50");
            }
            else if (age > 30)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 18)
            {
                Console.WriteLine("Over 18");
            }
            else
            {
                Console.WriteLine("Under 18");
            }
        }
    }
}
