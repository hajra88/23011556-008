using System;

namespace Assignment23011556
{
    public class ArrayCountEvenOdd
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++) arr[i] = int.Parse(Console.ReadLine()!);

            int even = 0, odd = 0;
            foreach (int x in arr) { if (x % 2 == 0) even++; else odd++; }
            Console.WriteLine($"Even count = {even}, Odd count = {odd}");
        }
    }
}
