using System;
using System.Threading;

namespace z4
{
    class Program
    {
        public static int E = 0, ThdreadInUse = 0;
        public static int[] c;

        static void Main(string[] args)
        {
            int n = 1000;
            int threads = 10;
            c = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                c[i] = rand.Next(20);
            }
            Thread[] ArrayOfThdreads = new Thread[threads];
            for (int i = 0; i < threads - 1; i++)
            {
                ArrayOfThdreads[i] = new Thread(new ThreadStart(delegate () {
                    for (int j = n / threads * i; j < n / threads * (i + 1); j++)
                    {
                        if (c[j] % 2 == 0)
                        {
                            E += c[j];
                        }
                    }
                }));
                ThdreadInUse++;
                ArrayOfThdreads[i].Start();
                ArrayOfThdreads[i].Join();

            }
            Console.WriteLine($"Sum - {E}");
            Console.ReadKey();
        }
    }
}