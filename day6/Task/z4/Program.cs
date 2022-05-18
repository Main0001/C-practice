try
{
    int n = 5;
    int[,] matrix = new int[n, n];
    int mul = 1;
    Random r = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = r.Next(1, 20);
            if (j == 1)
            {
                mul *= matrix[i, j];
            }
        }
    }

    Console.WriteLine("Матрица:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    if (mul / 100 >= 1)
    {
        Console.WriteLine("произведение элементов второго столбца массива является трехзначным числом.");
    }
    else
    {
        Console.WriteLine("произведение элементов второго столбца массива не является трехзначным числом.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}