try
{
    Console.Write("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    double y = (x + 4) / (x + 8);
    double z = Math.Pow(Math.Cos(x), 3) / (x - 1);
    Console.WriteLine($"y = {Math.Round(y, 2)}");
    Console.WriteLine($"y = {Math.Round(z, 2)}: ");
}

catch (DivideByZeroException e)
{
    Console.WriteLine($"Exception: {e}");
}
catch (FormatException e)
{
    Console.WriteLine($"Exception: {e}");
}
