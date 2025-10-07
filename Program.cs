using System;

namespace Assignment23011556
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hajra8  |  Roll: 23011556-008(A)");
            Console.WriteLine("Select question (1-10): ");
            int choice = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            switch (choice)
            {
                case 1: EvenOdd.Run(); break;
                case 2: SimpleCalculator.Run(); break;
                case 3: GradeEvaluator.Run(); break;
                case 4: SumNatural.Run(); break;
                case 5: MultiplicationTable.Run(); break;
                case 6: FactorialCalc.Run(); break;
                case 7: ReverseNumber.Run(); break;
                case 8: ArrayMaxMin.Run(); break;
                case 9: ArrayCountEvenOdd.Run(); break;
                case 10: ArraySearch.Run(); break;
                default: Console.WriteLine("Invalid choice."); break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
