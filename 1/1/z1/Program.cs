using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            while (true)
            {
                try
                {
                    Console.Write("Enter x value (more or less than 0.5): ");
                    x = double.Parse(Console.ReadLine());
                    if (x < 0)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value cannot be a negative number or letter");
                }
            }
            if (x < 0.5)
            {
                y = (Math.Pow(Math.Log10(x), 3) + Math.Pow(x, 2)) / Math.Sqrt(x + 2);
            }
            else
            {
                y = Math.Cos(x) + 2 * Math.Pow(Math.Sin(x), 2);
            }

            Console.WriteLine($"y = {Math.Round(y, 4)}");
        }
    }
}
