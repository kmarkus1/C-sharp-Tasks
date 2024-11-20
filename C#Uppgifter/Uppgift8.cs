using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string ageAsString = Console.ReadLine();
            int Age = int.Parse(ageAsString);
            const int LegalAge = 18;

            if (Age >= LegalAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are under the legal age.");
            }

            int Counter = 1;

            while (Counter <= 5)
            {
                Console.WriteLine(Counter);
                Counter++;
            }
            switch (Counter)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            var name = "John";
            Console.WriteLine("Welcome " + name + " The loop iteretated 5 times and the switch case printed Invalid number");
               
        }
    }
}
