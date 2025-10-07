using System;

namespace Assignment23011556
{
    public class EvenOdd
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine(n % 2 == 0 ? $"{n} is Even." : $"{n} is Odd.");
        }
    }
}
