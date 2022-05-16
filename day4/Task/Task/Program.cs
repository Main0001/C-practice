try
{
    int x1, y1, x2, y2, x3, y3;
    Console.Write("x1=");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y1=");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("x2=");
    x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y2=");
    y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("x3=");
    x3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y3=");
    y3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"result = {d(f(x1, y1, x2, y2), f(x2, y2, x3, y3), f(x3, y3, x1, y1))}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double f(double x1, double y1, double x2, double y2)
{
    return Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 1 / 2);
}

double d(double a, double b, double c)
{
    return a + b + c;
}