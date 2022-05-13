Console.Write("N = ");

try
{
    int n = Convert.ToInt32(Console.ReadLine());
    double result = 0;
    string str = "";
    for (int i = 1; i <= n; i++)
    {
        result += Math.Pow(-1, i + 1) * (1.0 + (double)i / 10);
        str += Convert.ToString(Math.Pow(-1, i + 1) * (1.0 + (double)i / 10)) + ' ';
    }
    Console.WriteLine(str);
    Console.WriteLine("Result = " + Math.Round(result, 2));
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}