using System;
using System.Linq;

namespace z1
{
    class Program
    {
        static double negativeChoose(double[] array)
        {
            return array.Where(x => x < 0).Min();
        }
        static void Main(String[] args)
        {
            Random random = new Random();
            double[] array = new double[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
                Console.WriteLine($"{i} : {array[i]}");
            }

            double numberOfNegative = negativeChoose(array);
            Console.WriteLine($"Minimal negative element - {numberOfNegative}");
        }
    }
}
