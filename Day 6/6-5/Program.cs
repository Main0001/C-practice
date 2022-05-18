Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Formula(n));


static double Formula(int n)
{
    return Factorial(n + 2) / Factorial(n + 1);
}

static int Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}