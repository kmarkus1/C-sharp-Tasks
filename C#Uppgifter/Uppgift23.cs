using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Input here: ");
            string mainInput = Console.ReadLine();

            try
            {
                number = Convert.ToInt32(mainInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("error");
            }

            bool parse = int.TryParse(mainInput, out number);

            if (parse)
            {
                Console.WriteLine("it worked");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("did not work");
                Console.WriteLine(number);
            }
        }
    }
}
