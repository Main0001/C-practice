try
{
    const double A = Math.PI / 4;
    const double B = 4 / Math.PI;
    const double M = 20;

    double h = (B - A) / M;

    double result = 0;
    double x = 0;
    for (double i = 0.1; i < 2.1; i += 0.1)
    {
        x = i + h;
        result = Math.Cos(1 / x);
        Console.WriteLine("x = " + result);
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}