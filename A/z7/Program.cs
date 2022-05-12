using System;

namespace z7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double z1 = 1 - 1 / 4 * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);
            double z2 = (Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4));
            Console.WriteLine($"z1 = {Math.Round(z1,4)} and z2 = {Math.Round(z2, 4)}");
        }
    }
}
