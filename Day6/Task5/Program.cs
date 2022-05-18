try
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    double result = Fact(number - 1) / Fact(number);
    Console.WriteLine($"Результат выражения: {Math.Round(result, 2)}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double Fact(int n)
{
    if (n == 1) return 1;
    return n * Fact(n - 1);
}