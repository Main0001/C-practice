using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double result = (Math.Sqrt(x * Math.Sin(2 * x) + Math.Pow(2.718, (-2 * 1))) * (x + Math.Log10(Math.Sqrt(x))));
            Console.WriteLine($"Result: {Math.Round(result, 4)}");
        }
    }
}
