while (true)
{
    try
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Formula 1 = {Formula(x)}");
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
        if ((x > -5) && (x < 1)) return x - 3;
        else if (x >= 1) return Math.Pow(x, 2) / (3 * x - 9);
        else throw new Exception("X - Not in range!");
    }
    catch (DivideByZeroException)
    {
        throw new DivideByZeroException();
    }

}