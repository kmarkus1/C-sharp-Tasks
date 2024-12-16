using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            //Dictionary that words and definitions get added to
            Dictionary<string, string> Words = new Dictionary<string, string>();

            //Menu loop
            while (true)
            {
                Console.WriteLine("1. Add a word and its definition");
                Console.WriteLine("2. Remove a word");
                Console.WriteLine("3. Show all words and their definitions");
                Console.WriteLine("4. Exit");

                Console.Write("Choose option between 1 and 4: ");
                //Store input in a string
                string menuOption = Console.ReadLine();

                //if menuOption is "4" break loop
                if (menuOption == "4")
                {
                    break;
                }

                //Switch case for options 1, 2 and 3
                switch(menuOption)
                {
                    case "1":
                        //Prompt user for word and definition and store them
                        Console.Write("Enter the word: ");
                        string wordToAdd = Console.ReadLine();

                        Console.Write("Enter the definition of the word: ");
                        string definition = Console.ReadLine();

                        //if word already exists in dictionary ask user if they want to overwrite it
                        if(Words.TryGetValue(wordToAdd, out var value))
                        {
                            Console.Write("This word already exists. Do you want to overwrite it? (yes/no) ");
                            string overwrite = Console.ReadLine();

                            if (overwrite == "yes") //if yes overwrite
                            {
                                Words[wordToAdd] = definition;
                            }
                        }
                        else
                        {
                            //Add word and definition to dictionary
                            Words[wordToAdd] = definition;
                        }
                        break;
                    case "2":
                        //Ask for the word to remove and store it
                        Console.Write("Enter the word to remove: ");
                        string wordToRemove = Console.ReadLine();

                        //if word is in dictionary remove it and print confirmation message
                        if (Words.ContainsKey(wordToRemove))
                        {
                            Words.Remove(wordToRemove);
                            Console.WriteLine($"{wordToRemove} Removed from dictionary");
                        }
                        else
                        {
                            //if word was not in dictionary inform user
                            Console.WriteLine($"{wordToRemove} not found");
                        }
                        break ;
                    case "3":
                        //Print all items in dictionary
                        foreach (var item in Words)
                        {
                            Console.WriteLine($"Word: {item.Key}  Definition: {item.Value}");
                        }
                        break ;
                    default:
                        Console.WriteLine("Input must be 1, 2, 3 or 4.");
                        break;
                }
            }
        }
    }
}
