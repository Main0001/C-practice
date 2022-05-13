try
{
    Console.Write("A = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("B = ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = a; i <= b; i++)
    {
        result *= i;
    }

    Console.WriteLine("Результат умножения: " + result);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}