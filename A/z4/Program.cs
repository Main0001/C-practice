using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 12, v2 = 8, t1 = 39, t2 = 53, V;
            float T;
            Console.WriteLine($"Volume of liquids: {V = v1 + v2}");
            Console.Write($"Temperature of liquids: {T = (v1 * t1 + v2 * t2) / V}");
        }
    }
}
