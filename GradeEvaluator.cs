﻿using System;

namespace Assignment23011556
{
    public class GradeEvaluator
    {
        public static void Run()
        {
            Console.Write("Enter marks (0-100): ");
            int marks = int.Parse(Console.ReadLine()!);
            if (marks >= 85) Console.WriteLine("Grade: A");
            else if (marks >= 70) Console.WriteLine("Grade: B");
            else if (marks >= 55) Console.WriteLine("Grade: C");
            else if (marks >= 40) Console.WriteLine("Grade: D");
            else Console.WriteLine("Grade: F");
        }
    }
}
