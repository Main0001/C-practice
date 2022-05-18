try
{
    Console.Write($"Введите N = ");
    var n = int.Parse(Console.ReadLine());

    Console.Write($"Введите a = ");
    var a = int.Parse(Console.ReadLine());

    Console.Write($"Введите b = ");
    var b = int.Parse(Console.ReadLine());

    int[,] matrix = new int[n, n];
    int count = 0;
    int summI = 0;
    Random r = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = r.Next(a, b);
            if (matrix[i, j] > 0)
            {
                count += 1;
            }
        }
    }

    Console.WriteLine("\nМатрица:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Положительные элементы: {count}");
    Console.WriteLine("\nСумма каждой строки:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            summI += matrix[i, j];
        }
        Console.WriteLine($"Summ {i} строки = {summI}");
        summI = 0;
    }

}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}