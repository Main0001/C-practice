class Tab
{
    static void Main(String[] args)
    {
        try
        {
            const double A = 0;
            const double B =  Math.PI / 2;
            const double M = 20;

            double h = (B - A) / M;

            double result = 0;
            double x = 0;
            for (double i = 0.1; i < 2.1; i += 0.1)
            {
                x = i + h;
                result = Math.Sin(x) - Math.Cos(x);
                Console.WriteLine("x = " + x);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}