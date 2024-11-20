using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your grade: ");
            string inputGrade = Console.ReadLine();
            int grade = int.Parse(inputGrade);

            switch (grade)
            {
                case 0:
                    Console.WriteLine(grade + ": Fail");
                    break;
                case 1:
                    Console.WriteLine(grade + ": Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine(grade + ": Ok");
                    break;
                case 3:
                    Console.WriteLine(grade + ": Satisfactory");
                    break;
                case 4:
                    Console.WriteLine(grade + ": Good");
                    break;
                case 5:
                    Console.WriteLine(grade + ": Excellent");
                    break;
                default:
                    Console.WriteLine(grade + ": is not a valid grade");
                    break;
            }
        }
    }
}
