using System;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A;
            while (true)
            {
                try
                {
                    Console.Write("Enter N value: ");
                    N = int.Parse(Console.ReadLine());
                    Console.Write("Enter A value: ");
                    A = int.Parse(Console.ReadLine());
                    if (!((A <= 5 && A >= -5) || (N <= 10 && N >= 1)))
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
            Console.WriteLine($"Number {A} in Pow {N} = {Math.Round(Math.Pow(A, N), 4)}");
        }
    }
}
