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

    int i = b;
    while (i > a)
    {
        if (i % 2 == 0)
        {
            if (i % 10 == x || i % 10 == y)
                Console.WriteLine(i);
        }
        i--;
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}