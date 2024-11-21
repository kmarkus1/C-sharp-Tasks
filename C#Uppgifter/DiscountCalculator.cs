using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get price from user
            Console.Write("Enter the original price of the product: ");
            string priceInput = Console.ReadLine();
            //condition for loop
            bool doTheLoop = true;

            while (doTheLoop)
            {
                //Change priceInput from string to double
                if (double.TryParse(priceInput, out double originalPrice))
                {

                 
                }
                else
                {
                    Console.WriteLine("Invalid price! Please enter a positive number.");
                    break;
                }

                if (originalPrice < 0)
                {
                    Console.WriteLine("Invalid price! Please enter a positive number.");
                    break;
                }

                Console.Write("Enter discount type (student/senior/none): ");
                string discountType = Console.ReadLine();
                discountType.ToLower();
                double discountPercentage = 0;
                //Flag for valid input
                bool badInput = false;

                switch (discountType)
                {
                    case "student":
                        discountPercentage = 0.15;
                        break;
                    case "senior":
                        discountPercentage = 0.20;
                        break;
                    case "none":
                        discountPercentage = 0.00;
                        break;
                    default:
                        badInput = true;
                        Console.WriteLine("Invalid discoutn type! please enter 'student', 'senior' or 'none'.");
                        break;
                }
                //If input was invalid break loop
                if (badInput)
                {
                    break;
                }

                double discount = discountPercentage * originalPrice;
                double finalPrice = originalPrice - discount;
                Console.WriteLine();
                Console.WriteLine(String.Format("Original Price: " + "$" + "{0:0.00}", originalPrice));
                Console.WriteLine("Discount Type: " + char.ToUpper(discountType[0]) + discountType.Substring(1));
                Console.WriteLine(String.Format("Discount Amount: " + "$" + "{0:0.00}", discount));
                Console.WriteLine(String.Format("Final Price: " + "$" + "{0:0.00}", finalPrice));
                //flag for ending loop
                doTheLoop = false;
                
            }

            Console.ReadLine();
            

           
            
            



        }
    }
}
