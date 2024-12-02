using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift18
{
    internal class Program
    {
        static int Triangle(int width, int height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The area of the triangle is {Triangle(width, height)}");
        }
    }
}
