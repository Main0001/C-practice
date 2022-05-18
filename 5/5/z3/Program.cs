using System;

namespace z3
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Enter N value (dimensions): ");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            int a, b;
            Console.Write("Enter a value (renge start): ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value (renge end): ");
            b = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(a, b);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine($"Avarage = {Avarage(array, 5)}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception - Divide By Zero! {e}");
            }

            Console.Write("Row sum: \n");

            WorkWithMatrix(array);
        }
        static void WorkWithMatrix(int[,] array)
        {
            int[] s = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    s[i] += array[i, j];
                Console.WriteLine($"{i} | {s[i]}");
            }
        }
        static double Avarage(int[,] array, int G)
        {
            int sr = 0;
            int indexer = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        sr += array[i, j];
                        indexer++;
                    }
                }
            }
            return sr / indexer;
        }
    }
}
