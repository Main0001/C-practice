using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        const int N = 5; 
        const int M = 6;

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] matrix = new int[N, M]; 

            for (int i = 0; i < N; i++)
                matrix.SetRow(Enumerable.Range(0, M).Select(x => x = rnd.Next(-10, 20)).ToArray(), i);
          


            for (int i = 0; i < N; i++)
                Console.WriteLine(string.Join("\t", matrix.GetRow(i)));


            var result = Enumerable.Range(0, M).Select(x => matrix.GetColumn(x).Sum() / M);

            Console.WriteLine();
            Console.WriteLine(string.Join("\t", result));

            Console.ReadKey(true);
        }
    }
    public static class ArrayExtensions
    {
        public static long SetRow<T>(this T[,] array, T[] data, int i)
        {
            return Enumerable.Range(0, array.GetLength(1)).Select(j => array[i, j] = data[j]).LongCount();
        }

        public static T[] GetRow<T>(this T[,] data, int i)
        {
            return Enumerable.Range(0, data.GetLength(1)).Select(j => data[i, j]).ToArray();
        }

        public static T[] GetColumn<T>(this T[,] data, int i)
        {
            return Enumerable.Range(0, data.GetLength(0)).Select(j => data[j, i]).ToArray();
        }
    }

}