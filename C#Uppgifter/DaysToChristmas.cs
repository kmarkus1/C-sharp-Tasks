using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagarTillJul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2024, 12, 25);

            

            if (today > christmas)
            {
                
                christmas = christmas.AddYears(1);
            }
            
            Console.WriteLine($"There are {(christmas.Date - today.Date).Days} days until Christmas!");

            
        }
    }
}
