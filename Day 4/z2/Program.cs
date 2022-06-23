static void Main(string[] args)
{
    Console.Write("a=");
    double a = double.Parse(Console.ReadLine());
    Console.Write("b=");
    double b = double.Parse(Console.ReadLine());
    Console.Write("h=");
    double h = double.Parse(Console.ReadLine());
    for (double i = a; i <= b; i += h)
        Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
    Console.WriteLine("Override!--------------");
    double y = 0;
    for (double i = a; i <= b; i += h)
    {
        f(i, out y);
        Console.WriteLine("f({0:f2})={1:f4}", i, y);
    }
}

static double f(double y, double x, double a, double b)
{
    if (Math.Pow(x, 2) + 5 < 0) y = a + b;
    else if (0 <= Math.Pow(x, 2) - 5 * x && Math.Pow(x, 2) - 5 * x < 10) y = a - b;
    else if (Math.Pow(x, 2) - 5 > 10) y = a * b;
    else y = 0;
    return y;
}

static void f(double x, out double y)
{
    double a; 
    double b;
    if (Math.Pow(x, 2) + 5 < 0) y = a + b;
    else if (0 <= Math.Pow(x, 2) - 5 * x && Math.Pow(x, 2) - 5 * x < 10) y = a - b;
    else if (Math.Pow(x, 2) - 5 > 10) y = a * b;
    else y = 0;
}
