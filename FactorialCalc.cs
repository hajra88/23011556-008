using System;

namespace Assignment23011556
{
    public class FactorialCalc
    {
        public static void Run()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine()!);
            long fact = 1;
            int i = 1;
            while (i <= n) { fact *= i; i++; }
            Console.WriteLine($"Factorial = {fact}");
        }
    }
}
