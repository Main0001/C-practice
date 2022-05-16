class Programm
{

    public static void Main(string[] args)
    {
        try
        {
            Console.Write("введит a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("введит b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("введит h = ");
            var h = double.Parse(Console.ReadLine());

            double y;
            for (double i = a; i <= b; i += h)
            {
                Task(i, out y);
                Console.WriteLine($"f{Math.Round(i, 1)} = {y}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static double Task(double x)
    {
        double y = 0;
        if (x > 0)
        {
            y = x;
        }
        else if (x >= -1 && x <= 0)
        {
            y = 0;
        }
        else
        {
            y = Math.Pow(x, 2);
        }

        return y;
    }

    static void Task(double x, out double y)
    {
        y = 0;
        if (x > 0)
        {
            y = x;
        }
        else if (x >= -1 && x <= 0)
        {
            y = 0;
        }
        else
        {
            y = Math.Pow(x, 2);
        }
    }
}




