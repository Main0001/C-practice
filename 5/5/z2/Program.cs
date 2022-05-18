using System;
using System.Linq;

namespace z2
{
    class Program
    {
        public static object Find(int[] arr)
        {
            return arr.Where(x => x % 3 == 0 && x % 5 != 0).Count();
        }

        static void Main(String[] args)
        {
            int fromValue = 0, toValue = 0;
            Console.Write("Enter first array value (from): ");
            fromValue = int.Parse(Console.ReadLine());
            Console.Write("Enter second array value (to): ");
            toValue = int.Parse(Console.ReadLine());

            int[] array = new int[toValue+1];
            for (fromValue = fromValue; fromValue <= toValue; fromValue++)
            {
                array[fromValue] = fromValue;
                Console.WriteLine(array[fromValue]);
            }

            Console.WriteLine("Amount of numbers that are multiples of 3 and not multiples on 5: ");
            Console.WriteLine(Find(array));
        }
    }
}
