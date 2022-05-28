using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication3
{
    class Program
    {
        public static int b = 10, sum = 0, CurrentThread = 0;
        public static int[] c;

        static void Main(string[] args)
        {
            int n = 1000;
            int threads = 10;
            c = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                c[i] = r.Next(20);
            }
            Thread[] threadsArray = new Thread[threads];
            for (int i = 0; i < threads - 1; i++)
            {
                threadsArray[i] = new Thread(new ThreadStart(delegate () {
                    for (int j = n / threads * i; j < n / threads * (i + 1); j++)
                    {
                        if (c[j] % 2 == 0)
                        {
                            sum += c[j];
                        }
                    }
                }));
                CurrentThread++;
                threadsArray[i].Start();
                threadsArray[i].Join();

            }
            Console.WriteLine("count:{0}", sum);
            Console.ReadKey();
        }
    }
}