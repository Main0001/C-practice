class Dop
{
    static void Main(String[] args)
    {
        for (int i = 10; i <= 100; i++)
        {
            if (3 * (i % 10) * (i / 10) == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}