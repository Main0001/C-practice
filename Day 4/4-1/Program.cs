class Temp
{
    static void Main(string[] args)
    {
        static double Formula(int n, double x)
        {
            return Math.Pow(x, n) / n;
        }

        Console.WriteLine(Formula(2, 4) + Formula(4, 4) + Formula(6, 4));
    }
}
