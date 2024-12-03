using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift20
{
    class Circle
    {
        public double Radius;

        public Circle()
        {
            Radius = 0;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Circle radius = new Circle();
            radius.Radius = 1.5;
            Console.WriteLine(radius.Radius);
            Console.WriteLine($"Area of the circle is: {radius.CalculateArea()}");
        }
    }
}
