try
{
    Console.Write("введите a = ");
    var a = double.Parse(Console.ReadLine());
    Console.Write("введите b = ");
    var b = double.Parse(Console.ReadLine());
    Console.Write("введите h = ");
    var h = double.Parse(Console.ReadLine());

    for (double i = a; i <= b; i += h)
    {
        Console.WriteLine($"f{Math.Round(i, 1)} = {Task(i)}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double Task (double x)
{
    double y = 0;
    if (x > 0)
    {
        y = x;
    }
    else if (x >= -1 && x <= 0)
    {
        y = 0;
    }
    else
    {
        y = Math.Pow(x, 2);
    }

    return y;
}