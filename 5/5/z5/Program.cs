using System;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n value: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Expression result: {Expression(n)}");

        }

        static double Expression(int n)
        {
            return Fact(n + 2) / Fact(n);
        }

        static int Fact(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Fact(f - 1);
        }
    }
}
