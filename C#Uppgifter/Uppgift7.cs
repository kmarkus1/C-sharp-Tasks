using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("Loop finished");
        }
    }
}
