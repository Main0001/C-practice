const double X = 1;

double result = 0;

try
{
    result = Math.Log10(2 * X) + ((Math.Pow(Math.Sin(X), 2) + 1) / (2 * Math.Sqrt(Math.Pow(Math.E, 2) + 1) - Math.Cos(X - Math.PI)));
    Console.WriteLine($"Результат: {Math.Round(result, 2)}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}