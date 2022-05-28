using System.Threading.Tasks;
using System.Diagnostics;

Stopwatch sw = new Stopwatch();
Stopwatch sw2 = new Stopwatch();
Task task1 = new Task(method);
Task task2 = new Task(method);

sw.Start();
task1.Start();
task1.Wait();
sw.Stop();

sw2.Start();
task2.Start();
task2.Wait();
sw2.Stop();

TimeSpan ts = sw.Elapsed;
TimeSpan ts2 = sw2.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);

string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
Console.WriteLine("RunTime2 " + elapsedTime);

static void method()
{
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        sum += i;
        Console.WriteLine("task Прибавка к переменной sum значения =  " + i);
    }
    Console.WriteLine($"Result task = {sum}");
}