using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Enter x: ");
            x = double.Parse(Console.ReadLine());
            double y;
            if (x < 0.5)
            {
                y = (Math.Pow(Math.Log10(x), 3) + Math.Pow(x, 2)) / Math.Sqrt(x + 2);
            }
            else
            {
                y = Math.Cos(x) + 2 * Math.Pow(Math.Sin(x), 2);
            }

            Console.WriteLine($"y = {y}");
        }
    }
}
