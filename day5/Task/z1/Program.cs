try
{
    Console.Write("Введите х = ");
    int x = int.Parse(Console.ReadLine());
    double y1 = ((Math.Cos(Math.Pow(x, 2))) / (9 * x - 9)) + Math.Pow(Math.Sin(x), 3);

    //if (double.IsInfinity(y1))
    //{
    //    Console.WriteLine("Inf");
    //}

    double y2 = (Math.Pow(Math.Sin(x), 3)) / (Math.Pow(x, 3));

    Console.WriteLine($"a = {y1}");
    Console.WriteLine($"b = {y2}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}