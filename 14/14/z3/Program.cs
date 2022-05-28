using System;
using System.Threading.Tasks;

try
{
    Console.Write("Enter A value: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());

    var fTask = Task.Run(() => Method1(a, n));
    var sTask = Task.Run(() =>
    {
        Method1(a, n);
        Method2(a, n);
    });

    fTask.Wait();
    sTask.Wait();
}
catch (Exception e)
{
    Console.WriteLine($"An error occured! {e.Message}");
}

void Method1(int a, int n)
{
    int sum = a;
    for (int i = 1; i <= n; i++)
    {
        sum += (int)Math.Pow(a, i);
    }
    Console.WriteLine(sum);
}

void Method2(int a, int n)
{
    int sum = a;
    for (int i = 1; i <= n; i++)
    {
        sum *= (int)Math.Pow(a, i);
    }
    Console.WriteLine(sum);
}