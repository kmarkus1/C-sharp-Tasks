using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teachers = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show all");
                Console.WriteLine("4. Exit");

                Console.Write("Choose option between 1 and 4: ");
                string menuOption = Console.ReadLine();

                if (menuOption == "4")
                {
                    break;
                }

                switch(menuOption)
                {
                    case "1":
                        Console.Write("Enter the name of the new subject: ");
                        string subject = Console.ReadLine();

                        Console.Write("Teachers name: ");
                        string teacher = Console.ReadLine();

                        teachers[subject] = teacher;
                        Console.WriteLine("Subject and teacher added.");
                        break;
                    case "2":
                        Console.Write("Enter the name of the subject to remove: ");
                        string subjectRemove = Console.ReadLine();

                        if(teachers.ContainsKey(subjectRemove))
                        {
                            teachers.Remove(subjectRemove);
                            Console.WriteLine($"{subjectRemove} Removed from list.");
                        }
                        else
                        {
                            Console.WriteLine($"{subjectRemove} was not found in list");
                        }
                        break;
                    case "3":
                        foreach(var item  in teachers)
                        {
                            Console.WriteLine($"Subject: {item.Key} Teacher: {item.Value}");
                        }
                        break;
                    default:
                        Console.WriteLine("Input must be 1, 2, 3 or 4.");
                        break ;
                }
            }
        }
    }
}
