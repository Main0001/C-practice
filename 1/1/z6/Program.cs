using System;

namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double A = 0;
            const double B = Math.PI / 4;
            const double M = 20;

            double h = (B - A) / M;

            double result = 0;
            double x = 0;
            for (double i = 0.1; i < 2.1; i += 0.1)
            {
                x = i + h;
                result = Math.Sin(x) - Math.Tan(x);
                Console.WriteLine($"x = {Math.Round(x,4)}");
            }
        }
    }
}
