var x = 3.5;

try
{
    var y = Math.Pow(Math.Cos(x), 2) - (Math.Sqrt(Math.Pow(x, 3)) + 1) / (Math.Sin(x) + Math.Pow(Math.E, Math.Log10(2 * x)));
    Console.WriteLine($"result = {y}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}