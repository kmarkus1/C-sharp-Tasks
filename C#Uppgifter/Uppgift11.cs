using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the message: C# is fun I am going to code C# tomorrow ");
            var message = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(message);

            char[] messageArray = message.ToArray();
            Array.Reverse(messageArray);
            Console.WriteLine(messageArray);

            

            foreach(char c in message) Console.WriteLine(c);

            Console.WriteLine();
            
            foreach(char c in messageArray) Console.WriteLine(c);

        }
    }
}
