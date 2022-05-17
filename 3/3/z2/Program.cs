using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter h value: ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            Console.WriteLine("Overload.");
            double y = 0;
            for (double i = a; i <= b; i += h)
            {
                f(i, out y);
                Console.WriteLine("f({0:f2})={1:f4}", i, y);
            }
        }
        public static double f(double x)
        {
            double y;
            if ((x - 1) > 1) y = -1;
            else if ((x - 1) < 1) y = 1;
            else y = 0;
            return y;
        }
        public static void f(double x, out double y)
        {
            if ((x - 1) > 1) y = -1;
            else if ((x - 1) < 1) y = 1;
            else y = 0;
        }
    }
}
