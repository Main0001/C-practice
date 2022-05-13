try
{
    Console.Write("A = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("B = ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("X = ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    for (int i = b; i > a; i--)
    {
        if (i % 2 == 0)
        {
            if (i % 10 == x || i % 10 == y)
                Console.WriteLine(i);
        }
    }
    Console.WriteLine();

    int c = b;
    while (c > a)
    {
        if (c % 2 == 0)
        {
            if (c % 10 == x || c % 10 == y)
                Console.WriteLine(c);
        }
        c--;
    }
    Console.WriteLine();

    c = b;
    do
    {
        if (c % 2 == 0)
        {
            if (c % 10 == x || c % 10 == y)
                Console.WriteLine(c);
        }
        c--;
    }
    while (c > a);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}