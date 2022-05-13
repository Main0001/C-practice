using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
                a++;
            for (int i = a; i < b; i += 2)
                if (i % 5 != 0)
                    Console.Write($"{i} ");
        }
    }
}
