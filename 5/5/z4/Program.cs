using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n value: ");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            int a, b;
            Console.Write("Enter a value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
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

            printEmptyPlaces(array);
        }

        static void printEmptyPlaces(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        Console.WriteLine($"Empty place: ({i} wagon, {j} place)");
                    }
                }
            }
        }
    }
}
