using System;

namespace z3._3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;
            Console.Write("Enter n value: ");
            int n = int.Parse(Console.ReadLine());
            res = n;
            Console.Write("Result: ");
            for (int i = 0; i < 100; i++)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                Console.Write($"{n} ");
                if (n == 1)
                    break;

            }

        }
    }
}
