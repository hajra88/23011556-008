using System;

namespace Assignment23011556
{
    public class ArraySearch
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++) arr[i] = int.Parse(Console.ReadLine()!);

            Console.Write("Enter number to search: ");
            int target = int.Parse(Console.ReadLine()!);
            bool found = false;
            foreach (int x in arr) { if (x == target) { found = true; break; } }
            Console.WriteLine(found ? "Number found." : "Number not found.");
        }
    }
}
