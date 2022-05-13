try
{
    Console.WriteLine("Введите х = ");
    var x = double.Parse(Console.ReadLine());

    if (x <= 2 && x >= 1)
    {
        var y = Math.Pow(x, 2) * Math.Log10(x);
        Console.WriteLine($"y = {y}");
    }
    else if (x < 1)
    {
        var y = 1;
        Console.WriteLine($"y = {y}");
    }
    else
    {
        var y = Math.Pow(Math.E, 2 * x) * Math.Cos(5 * x);
        Console.WriteLine($"y = {y}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}