using System;
using System.Collections.Generic;
using System.Threading.Tasks;

try
{
    var Summ = 0;
    var multiple = 1;
    ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 46, 83, 15, 39 }, Expression);

    void Expression(int a, ParallelLoopState end)
    {
        Console.WriteLine($"Result of summing numbers = {Summ += a}");
        Console.WriteLine($"Result of multiplying numbers = {multiple *= a}");

        if (Summ > 131)
        {
            Console.WriteLine("Cycle interrupted (Summ is over 39)");
            end.Break();
        }
    }
}
catch (Exception e)
{
    Console.WriteLine($"An error occured - {e.Message}");
}