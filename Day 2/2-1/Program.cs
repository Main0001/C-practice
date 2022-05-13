class Formula
{
    static void Main(String[] args)
    {
        const double pi = 3.14;
        double x = 0.0;
        while (true)
        {
            try
            {
                Console.Write("Enter x: ");
                x = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }

        double y = 0.0;
        if (x < pi)
        {
            y = x + 2 * x * Math.Sin(3 * x);
        }
        else
        {
            y = Math.Cos(x) + 2;
        }

        Console.WriteLine($"Y = {y}");
    }
}