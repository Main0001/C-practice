try
{
    Console.Write("Введите n = ");
    var n = int.Parse(Console.ReadLine());
    double result = Math.Pow(n, 2);

    for (int i = 0; i <= n; i++)
    {
        result += Math.Pow(n + i, 2);
    }
    result += Math.Pow(2 * n, 2);
    Console.WriteLine($"result = {result}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}