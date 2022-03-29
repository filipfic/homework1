
using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            string val;
            int userInput;
            Console.WriteLine("Enter the first number : ");
            val = Console.ReadLine();
            userInput = Convert.ToInt32(val);
            Console.WriteLine("You entered = {0}", userInput);
            string value;
            int result;
            Console.WriteLine("Enter the second number : ");
            value = Console.ReadLine();
            result = Convert.ToInt32(value);
            Console.WriteLine("You entered = {0}", result);
            string someOperator;
            Console.WriteLine("Please enter the operator you want to use: ");
            someOperator = Console.ReadLine();
            if (someOperator == "+")
            {
                Console.WriteLine(userInput + result);
            }
            else if (someOperator == "-")
            {
                Console.WriteLine(userInput - result);
            }
            else if (someOperator == "/")
            {
                Console.WriteLine(userInput / result);
            }
            else if (someOperator == "*")
            {
                Console.WriteLine(userInput * result);
            }
        }
    }
}

