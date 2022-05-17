while (true)
{
    try
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Formula 1 = {Formula(x)}");
        Console.WriteLine($"Formula 2 = {Formula2(x)}");
        break;
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Sorry, it's format exception (Error: {e})");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Divide by zero (x / 0) (Error: {e})");
    } 
    catch (Exception e)
    {
        Console.WriteLine($"Some error (Error: {e})");
    }
}


static double Formula(double x)
{
    try
    {
        return x + ((2 * x) / (4 * Math.Sin(x)));
    }
    catch (Exception)
    {
        throw new DivideByZeroException();
    }
    
}

static double Formula2(double x)
{
    try
    {
        return x - 3 +(1/ Math.Tan(x - 1));
    }
    catch (Exception)
    {
        throw new DivideByZeroException();
    }

}