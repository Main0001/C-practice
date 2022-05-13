using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B value: ");
            int b = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
                a++;
            for (int i = a; i < b; i += 2)
                if (i % 5 != 0)
                    Console.Write($"{i} ");
                    Console.WriteLine();
            int c = a;
            while (c < b)
            {
                if (c % 5 != 0 && c % 2 == 0)
                    Console.Write($"{c} ");
                c++;
            }
            Console.WriteLine();
            c = a;
            do
            {
                if (c % 5 != 0 && c % 2 == 0)
                    Console.Write($"{c} ");
                c++;
            }
            while (c < b);
        }
    }
}
