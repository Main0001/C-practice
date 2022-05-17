try
{
    Console.Write($"Введите A: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите B: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите C: ");
    double c = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите A1: ");
    double a1 = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите B1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите C1: ");
    double c1 = Convert.ToDouble(Console.ReadLine());

    SortInc3(a, b, c, out a, out b, out c);
    SortInc3(a1, b1, c1, out a1, out b1, out c1);

    Console.WriteLine($"A = {Math.Round(a, 2)}, B = {Math.Round(b, 2)}, C = {Math.Round(c, 2)}");
    Console.WriteLine($"A1 = {Math.Round(a1, 2)}, B1 = {Math.Round(b1, 2)}, C1 = {Math.Round(c1, 2)}");
}

catch (DivideByZeroException e)
{
    Console.WriteLine($"Exception: {e}");
}

catch (FormatException e)
{
    Console.WriteLine($"Exception: {e}");
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}

void SortInc3(double a, double b, double c, out double resA, out double resB, out double resC)
{
    if (a > b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    if (a > c)
    {
        double temp = a;
        a = c;
        c = temp;
    }

    if (b > c)
    {
        double temp = b;
        b = c;
        c = temp;
    }

    resA = a;
    resB = b;
    resC = c;
}