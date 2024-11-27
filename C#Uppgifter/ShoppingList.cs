using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            while (true)
            {
                Console.Write("Add item to shopping list or type 's' to stop: ");
                string item = Console.ReadLine();

                if (item == "s")
                {
                    break;
                }
                shoppingList.Add(item);
            }

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write($"{shoppingList[i]} ");
            }
        }
    }
}
