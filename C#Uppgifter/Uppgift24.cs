using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift24
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Product()
        {
            name = "test";
            price = 0;
            stock = 0;
        }
    }
    internal class Program
    {
        static Product Product = new Product();
        static void SetName(string productName)
        {
            
            Product.Name = productName;
        }
        public static void SetPrice(double price)
        {
            
            Product.Price = price;
        }
        public static void SetStock(int stock)
        {
            
            Product.Stock = stock;
        }
        public static string GetName()
        {
            return Product.Name;
        }
        public static double GetPrice()
        {
            return Product.Price; 
        }
        public static int GetStock()
        {
            return Product.Stock;
        }
        public static void GetAll()
        {
            Console.WriteLine($"Name: {GetName()}, Price: {GetPrice()}, Stock: {GetStock()}");
        }

        static void Main(string[] args)
        {
            SetName("Phone");
            SetPrice(599);
            SetStock(5);

            Console.WriteLine("Initial product details:");
            GetAll();
            Console.WriteLine("Updated product details:");

            SetName("Laptop");
            SetPrice(999.99);
            SetStock(10);

            GetAll();

            Console.ReadLine();
        }
    }
}
