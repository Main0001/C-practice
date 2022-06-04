using System;
using System.Threading;
using System.Threading.Tasks;

int a = 0;

while (true)
{
    try
    {
        Console.Write($"Enter a value: ");
        a = int.Parse(Console.ReadLine());

        Task[] tasks = new Task[2]
        {
            new Task(() => Console.WriteLine($"First Task: Z1 - {FirstExpression(a)}")),
            new Task(() => {
            Console.WriteLine($"Second Task: Z2 - {SecondExpression(a)}");

                }
            )
        };

        foreach (var t in tasks)
        {
            t.Start();

        }

        int ind = Task.WaitAny(tasks);
        Console.WriteLine($"Task {tasks[ind].Id} completed - waiting end.");
        Console.WriteLine("\nCurrent Tusks status:");
        foreach (var t in tasks)
            Console.WriteLine($"Task {t.Id}: {t.Status}");
        Console.WriteLine();

        Task.WaitAll(tasks);
        Console.WriteLine("Tasks completed!");
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine($"An error occured - {e.Message}");
    }
}

double FirstExpression(int a)
{
    Thread.Sleep(10);
    var z1 = Math.Round((Math.Cos(a) + Math.Cos(2 * a) + Math.Cos(5 * a) + Math.Cos(7 * a)), 4);
    return z1;
}

double SecondExpression(int a)
{
    Thread.Sleep(200);
    var z2 = Math.Round((4 * Math.Cos(a / 2) * Math.Cos(5 / 2) * Math.Cos(4 * a)), 4);
    return z2;
}