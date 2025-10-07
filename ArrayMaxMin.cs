using System;

namespace Assignment23011556
{
    public class ArrayMaxMin
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++) arr[i] = int.Parse(Console.ReadLine()!);

            int max = arr[0], min = arr[0];
            foreach (int x in arr)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine($"Maximum = {max}, Minimum = {min}");
        }
    }
}
