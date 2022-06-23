/// <summary>
/// Double expression class
/// </summary>
/// <returns>Expression calc</returns>
static double Form(int n, double x)
{
    return Math.Cos(x) * 2 + Math.Sin(x) - 3;
}

Console.WriteLine(Form(2, 5) + Form(9, 3) + Form(4, 4));
