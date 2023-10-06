using System;

namespace SumOfGCPandLCM
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            GCDandLCMCalculator calculator = new(n, m);
            calculator.GetGCD(n, m);
            calculator.GetLCM(n, m);
            Console.WriteLine(calculator.GetSumOfGCDAndLCM(n, m));
        }
    }
}

