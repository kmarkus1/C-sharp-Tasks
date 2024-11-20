using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 5;

            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can't vote :(");
            }
        }
    }
}
