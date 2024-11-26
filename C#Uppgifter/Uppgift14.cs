using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] multiplicationArray = new int[length];
            int loopCounter = 0;

            Console.Write($"Multiplication Table for {num}: ");

            for (int i = 0; i < length; i++)
            {
                loopCounter++;
                multiplicationArray[i] = loopCounter*num;
                Console.Write($"{multiplicationArray[i]} ");
            }
            
            
        }
    }
}
