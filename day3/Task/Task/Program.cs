try
{
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    A clas = new A(a, b);

    clas.SummMethod(a, b);
    clas.MathMethod(a, b);
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

    public void SummMethod(int a, int b)
    {
        Console.WriteLine($"Результат первого выражения: {a + b}");
    }

    public void MathMethod(double a, double b)
    {
        Console.WriteLine($"Результат первого выражения: {(Math.Sin(b)) / (3 * a)}");
    }
}