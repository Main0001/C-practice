class Series
{
    static void Main(String[] args)
    {
        int N;
        while (true)
        {
            try
            {
                Console.Write("N: ");
                N = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }
        Console.WriteLine(N);
        double sum = 1;
        for (double i = 1; i <= N; i++)
        {
            sum += (double)(1 / i);
            Console.WriteLine($"{i} {1/i}");
        }
        Console.WriteLine("sum = {0:N4}", sum);
    }
}