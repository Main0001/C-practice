class Circle
{
    static void Main(String[] args)
    {
        const double pi = Math.PI;
        int r = 0;

        while (true)
        {
            try
            {
                Console.Write("R = ");
                r = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }
        Console.WriteLine($"L = {2 * pi * r}");
        Console.WriteLine($"S = {pi * Math.Pow(r, 2)}");
    }
}