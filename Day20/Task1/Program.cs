class Temp
{
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
        Console.WriteLine("Перегрузка!--------------");
        double y = 0;
        for (double i = a; i <= b; i += h)
        {
            f(i, out y);
            Console.WriteLine("f({0:f2})={1:f4}", i, y);
        }
    }
    /// <summary>
    /// Function value calculation
    /// </summary>
    /// <param name="x">value for function definition</param>
    /// <returns>function result</returns>
    public static double f(double x)
    {
        double y;
        if (x > 1) y = 1 / Math.Pow(1 + x, 2);
        else if (x < 1) y = Math.Pow(Math.Pow(x, 2) - 1, 2);
        else y = 0;
        return y;
    }
    /// <summary>
    /// Function value calculation, overload
    /// </summary>
    /// <param name="x">value for function definition</param>
    /// <param name="y"></param>
    public static void f(double x, out double y)
    {
        if (x > 1) y = 1 / Math.Pow(1 + x, 2);
        else if (x < 1) y = Math.Pow(Math.Pow(x, 2) - 1, 2);
        else y = 0;
    }
}