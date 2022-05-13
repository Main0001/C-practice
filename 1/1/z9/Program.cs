using System;

namespace z9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double A;
            while (true)
            {
                try
                {
                    Console.Write("Enter N value: ");
                    N = int.Parse(Console.ReadLine());
                    Console.Write("Enter A value: ");
                    A = double.Parse(Console.ReadLine());
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
            double sum = 1;
            for (double i = 1; i <= N; i++)
            {
                sum += (double)(Math.Pow(A, i));
            }
            Console.WriteLine("Sum = {0:N4}", sum);
        }
    }
}
