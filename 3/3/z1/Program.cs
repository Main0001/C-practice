using System;

namespace z1
{
    class Pentagon
    {
        static void Main(string[] args)
        {
            static double Square(double[] parametrs)
            {
                double p = 0;
                foreach (var item in parametrs)
                {
                    p += item;
                }
                p /= 2;
                return Math.Sqrt(p * (p - parametrs[0]) * (p - parametrs[1]) * (p - parametrs[2]));
            }
            double PentagonSquare = Square(new double[] { 5, 6, 7 }) + Square(new double[] { 5, 6, 7 }) + Square(new double[] { 5, 6, 7 });
            Console.WriteLine($"Traiangle square - {Math.Round(Square(new double[] { 5, 6, 7 }), 4)}");
            Console.WriteLine($"Pentagon square - {Math.Round(PentagonSquare, 4)}");
        }
    }
}
