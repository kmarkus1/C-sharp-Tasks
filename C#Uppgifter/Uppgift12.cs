using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password1 = Console.ReadLine();

            Console.Write("Enter the password again: ");
            string password2 = Console.ReadLine();

            bool passwordLength = password1.Length >= 6 && password2.Length >= 6;

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password");
            }
            else if (password1 == password2)
            {
                Console.WriteLine("Password match"); 
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }
            
        }
    }
}
