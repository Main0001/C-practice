try
{
    Console.Write("Введите размерность матрицы: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[n,n];

    Console.WriteLine("Введите левую границу диапазона допустимых значений: ");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите правую границу диапазона допустимых значений: ");
    int end = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rnd.Next(start, end + 1);
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }

    int[] ar = arr.Cast<int>().ToArray();
    int summ = ar.Where(x => x < 0).Select(x => x * x).Sum();

    Console.WriteLine($"Сумма квадратов отрицаельных чисел матрицы: {summ}");

    for (int i = 0; i < n; i++)
    {
        int minElem = arr[0, 0];
        for (int j = 0; j < n; j++)
        {
            minElem = arr[i,j] < minElem ? arr[i,j] : minElem;
        }
        Console.WriteLine($"Минимальный элемент {i} строки: {minElem}");
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}