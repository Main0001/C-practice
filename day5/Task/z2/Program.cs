try
{
    Console.Write("Введите х = ");
    var x = double.Parse(Console.ReadLine());

    if (x > -3 && x <= -1)
    {
        var f = 2 * x - 3;
        Console.WriteLine($"Result = {f}");
    }
    else if (x > -1 && x < 3)
    {
        var f = -2 / x;
        Console.WriteLine($"Result = {f}");
    }
    else if (x >= 3)
    {
        var f = x;
        Console.WriteLine($"Result = {f}");
    }
    else
    {
        throw new Exception("Выход за пределы диапозона");
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}