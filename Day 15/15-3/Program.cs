try
{
    Console.Write("Введите A: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    var task1 = Task.Run(() => FirstMethod(a, n));
    var task2 = Task.Run(() =>
    {
        FirstMethod(a, n);
        SecondMethod(a, n);
    });

    task1.Wait();
    task2.Wait();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void FirstMethod(int a, int n)
{
    int res = a;
    for (int i = 1; i <= n; i++)
    {
        res += (int)Math.Pow(a, i);
    }
    Console.WriteLine(res);
}

void SecondMethod(int a, int n)
{
    int res = a;
    for (int i = 1; i <= n; i++)
    {
        res *= (int)Math.Pow(a, i);
    }
    Console.WriteLine(res);
}