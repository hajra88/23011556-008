using System;

namespace Assignment23011556
{
    public class SimpleCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Enter operator (+,-,*,/): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine()!);

            switch (op)
            {
                case '+': Console.WriteLine($"Result = {a + b}"); break;
                case '-': Console.WriteLine($"Result = {a - b}"); break;
                case '*': Console.WriteLine($"Result = {a * b}"); break;
                case '/': Console.WriteLine(b != 0 ? $"Result = {a / b}" : "Cannot divide by zero"); break;
                default: Console.WriteLine("Invalid operator"); break;
            }
        }
    }
}
