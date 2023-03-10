using System;
namespace LineComparison
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            CalculateLength calculateLength1 = new CalculateLength(1, 2, 3, 4);
            double line1 = calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(5, 6, 7, 8);
            double line2 = calculateLength2.Calculate();
            calculateLength2.CheckEquality(line1, line2);
            calculateLength2.CompareLines(line1, line2);
        }
    }
}
    