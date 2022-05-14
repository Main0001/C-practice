try
{
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    A clas = new A(a, b);

    clas.FirstMethod(a, b);
    clas.SecondMethod(a, b);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class A
{
    public int first;
    public int second;

    public A(int first, int second)
    {
        this.first = first;
        this.second = second;
    }

    public void FirstMethod(int a, int b)
    {
        Console.WriteLine($"Результат первого выражения: {1 / (double)a + 1 / Math.Sqrt(b)}");
    }

    public void SecondMethod(int a, int b)
    {
        Console.WriteLine($"Результат первого выражения: {Math.Pow(a, 6)}");
    }
}