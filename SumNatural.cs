using System;

namespace Assignment23011556
{
    public class SumNatural
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 1; i <= n; i++) sum += i;
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
