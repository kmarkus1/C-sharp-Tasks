using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndCollections
{
    public class Inventory
    {
        //Private list to store the names of all items
        private List<string> items = new List<string>();

        //Private dictionary to store item details
        //Each key is the item's name, and the value is a tuple conatining the price and quantity
        private Dictionary<string, (double price, int stock)> itemDetails = new Dictionary<string, (double, int)>();

        //Method to add new items to the inventory
        public void AddItem(string name, double price, int stock)
        {
            items.Add(name);
            //Add or update item details in dictionary
            itemDetails[name] = (price, stock);
        }

        //Method to remove an item from inventory
        public void RemoveItem(string name)
        {
            //Attempt to remove item from list
            if (items.Remove(name))
            {
                itemDetails.Remove(name);
                Console.WriteLine($"{name} has been removed form the inventory.");
            }
            else
            {
                //if the item isn't in list notify user
                Console.WriteLine($"{name} does not exist in the innventory.");
            }
        }

        //Method to update the stock of a specific item
        public void UpdateStock(string name, int newStock)
        {
            //Check if the item is in dictionary
            if (itemDetails.TryGetValue(name, out var details))
            {
                //Update the stock value while keeping the price unchanged
                itemDetails[name] = (details.price, newStock);
                Console.WriteLine($"Stock of {name} updated to {newStock}");
            }
            else
            {
                //if the item doesn't exist notify user
                Console.WriteLine($"{name} is not currently in inventory");
            }
        }

        //Method to retrive and print all items along with their details
        public void PrintAllItems()
        {
            Console.WriteLine("current inventory");

            foreach (var item in items)
            {
                var details = itemDetails[item];
                Console.WriteLine($"Product: {item}, Price: {details.price}, Stock: {details.stock}");
            }
        }
        public void PrintMostExpensiveItem()
        {
            string expensiveItem = null; // variable to store the name of the most expensive item
            double highestPrice = 0; // Variable to store highest price found

            //Loop through all items to find the one with highest value
            foreach (var item in items)
            {
                var details = itemDetails[item];
                if (details.price > highestPrice)
                {
                    highestPrice = details.price;
                    expensiveItem = item;
                }
            }
            //If an expensive item was found print the details
            if (expensiveItem != null)
            {
                Console.WriteLine($"Most expensive item: {expensiveItem}, Price: {highestPrice}");
            }
            else
            {
                //if no items exist in the inventory notify user
                Console.WriteLine("No items in inventory");
            }
        }

        public void PrintTotalInventoryValue()
        {
            double totalValue = 0; // Value to accumulate the total value

            // Loop all items  and calculate their total value (Prie * stock)
            foreach(var item in items)
            {
                var details = itemDetails[item];
                totalValue += details.price * details.stock;
            }
            //Print total value of inventory
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            //Add products to the inventory
            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            //Print all current items and their details
            inventory.PrintAllItems();

            //Update the stock and quantity of Laptop
            inventory.UpdateStock("Laptop", 5);

            //Remove the Tablet from Inventory
            inventory.RemoveItem("Tablet");

            //Print the most expensive item in inventory
            inventory.PrintMostExpensiveItem();

            //Print total value of inventory
            inventory.PrintTotalInventoryValue();
        }
    }
}
