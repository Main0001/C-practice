for (int i = 100; i < 1000; i++)
{
    if (i == (Math.Pow(i, 2) % 1000))
    {
        Console.WriteLine(i);
    }
}