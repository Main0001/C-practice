static int Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}

try
{
    Console.Write("Введите n = ");
    var n = int.Parse(Console.ReadLine());
    var f = Factorial(n - 2) / Factorial(n - 4);
    Console.WriteLine($"result = {f}");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}