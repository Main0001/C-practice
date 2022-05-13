using System;

namespace z8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            while (true)
            {
                try
                {
                    Console.Write("Enter value(from -999 to 999): ");
                    N = int.Parse(Console.ReadLine());
                    if (N < -999 || N > 999)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is incorrect!");
                }
            }
            if (N == 0) Console.WriteLine("Zero number");
            else
            {
                if (N < 0)
                {
                    Console.WriteLine("Negative");
                }
                else Console.WriteLine("Positive");

                if (Math.Abs(N) / 100 > 0) Console.WriteLine("3-digit");
                else if (Math.Abs(N) / 10 > 0) Console.WriteLine("2-digit");
                else Console.WriteLine("1-digit");
            }
        }
    }
}
