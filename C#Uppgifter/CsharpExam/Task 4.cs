using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        int sum = Add(input1, input2);
        int difference = Subtract(input1, input2);
        int product = Multiply(input1, input2);
        double quotient = Divide(input1, input2);

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The difference of the numbers is: {difference}");
        Console.WriteLine($"The product of the numbers is: {product}");
        Console.WriteLine($"The quotient of the numbers is: {quotient}");

        Console.ReadLine();
    }

    static int Add(string num1AsString, string num2AsString)
    {
        //Convert the strings to int
        int num1 = Convert.ToInt32(num1AsString);
        int num2 = Convert.ToInt32(num2AsString);
        //return sum
        return num1 + num2;
    }

    static int Subtract(string num1AsString, string num2AsString)
    {
        //Convert the strings to int
        int num1 = Convert.ToInt32(num1AsString);
        int num2 = Convert.ToInt32(num2AsString);
        //return difference
        return num1 - num2;
    }


    static int Multiply(string num1AsString, string num2AsString)
    {
        //Convert the strings to int
        int num1 = Convert.ToInt32(num1AsString);
        int num2 = Convert.ToInt32(num2AsString);
        //return product
        return num1 * num2;
    }

    static double Divide(string num1AsString, string num2AsString)
    {
        //Convert strings to double
        double num1 = Convert.ToDouble(num1AsString);
        double num2 = Convert.ToDouble(num2AsString);
        //return quotient
        return num1 / num2;
    }
}
