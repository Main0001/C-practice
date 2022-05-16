try
{
    Console.Write("Введите начало диапазона: ");
    double start = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите конец диапазона: ");
    double end = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите длину шага: ");
    double step = Convert.ToDouble(Console.ReadLine());

    for (double i = start; i <= end; i += step)
    {
        Console.WriteLine($"f({Math.Round(i, 1)}) = {Math.Round(result(i), 1)}");
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static double result (double x)
{
    double y = 0;
    if (x < 0)
        y = 0;
    else if (x == 1)
        y = 1;
    else if (x > 0 && x != 1)
    {
        y = Math.Pow(x, 2) + 1;
    }
    return y;
}