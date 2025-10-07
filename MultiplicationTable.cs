using System;

namespace Assignment23011556
{
    public class MultiplicationTable
    {
        public static void Run()
        {
            Console.Write("Enter number for table: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
