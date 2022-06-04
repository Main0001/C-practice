using System;
using System.Threading.Tasks;

try
{
    const int A = -4;
    const int B = 6;

    Console.Write("Enter x value: ");
    var x = Double.Parse(Console.ReadLine());

    Parallel.For(A, B, Task);
}
catch (Exception e)
{
    Console.WriteLine($"An error occured - {e.Message}");
}

void Task(int x)
{
    Console.WriteLine($"Result X = {Math.Round(Math.Sin(x) - Math.Tan(x), 4)}");
}