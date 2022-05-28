using System;
using System.Threading.Tasks;
using System.Diagnostics;

static void Adding()
{
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        sum += i;
        Console.WriteLine($"Adding {i} to sum");
    }
    Console.WriteLine($"Result of adding = {sum}");
}

Stopwatch stop1 = new Stopwatch();
Stopwatch stop2 = new Stopwatch();
Task fTask = new Task(Adding);
Task sTask = new Task(Adding);

stop1.Start();
fTask.Start();
fTask.Wait();
stop1.Stop();

stop2.Start();
sTask.Start();
sTask.Wait();
stop2.Stop();

TimeSpan timespanF = stop1.Elapsed;
TimeSpan timespanS = stop2.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timespanF.Hours, timespanF.Minutes, timespanF.Seconds, timespanF.Milliseconds / 10);
Console.WriteLine("1) Elapsed time: " + elapsedTime);

string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timespanS.Hours, timespanS.Minutes, timespanS.Seconds, timespanS.Milliseconds / 10);
Console.WriteLine("2) Elapsed time: " + elapsedTime);

Console.ReadLine();