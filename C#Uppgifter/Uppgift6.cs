using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times should we loop? ");
            string xAsString = Console.ReadLine();
            int X = int.Parse(xAsString);

            for (int i = 1; i <= X; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop ended");
        }
    }
}
