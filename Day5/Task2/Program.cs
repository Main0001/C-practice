try
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    double y = 0;
    if (x > 1)
    {
        y = Math.Pow(x, 2);
    }

    else if (x > -4 && x <= 1)
    {
        y = (3 * x + 2) / (4 * x + 4);
    }

    else
    {
        throw new Exception("IndexOutOfRange");
    }

    Console.WriteLine($"y = {Math.Round(y, 2)}");
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