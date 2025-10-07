using System;

namespace Assignment23011556
{
    public class ReverseNumber
    {
        public static void Run()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine()!);
            int rev = 0;
            while (n != 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine($"Reversed = {rev}");
        }
    }
}
