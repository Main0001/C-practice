try
{
    int row = 12;
    int col = 20;
    int[,] arr = new int[row, col];

    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = rnd.Next(50, 101);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

    int sumFeb = 0;
    int sumOct = 0;
    for (int i = 0; i < col; i++)
    {
        sumFeb += arr[1, i];
        sumOct += arr[9, i];
    }

    Console.WriteLine($"Сумма зарплат в феврале: {sumFeb}");
    Console.WriteLine($"Сумма зарплат в октябре: {sumOct}");
    if (sumFeb < sumOct)
        Console.WriteLine("Верно");
    else
        Console.WriteLine("Неверно");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}