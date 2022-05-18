try
{
    int leng = 20;

    double[] arr = new double[leng];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 5, 2);
        Console.Write(arr[i] + "  ");
        if (i == 9)
            Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 1; i < 10; i++)
    {
        if (arr[i] < arr[i+10])
        {
            double temp = arr[i];
            arr[i] = arr[i+10];
            arr[i+10] = temp;
        }
    }

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i], 2) + "  ");
        if (i == 9)
            Console.WriteLine();
    }

    Array.Sort(arr);

    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i], 2) + "  ");
    }

    Console.WriteLine();

    Console.WriteLine("Введите число: ");
    double k = Convert.ToDouble(Console.ReadLine());

    int index = Array.BinarySearch(arr, k);
    if (index < 0)
    {
        Console.WriteLine("Число не найдено");
    }
    else
    {
        Console.WriteLine($"Число {k} находится в массиве под индексом {index}");
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}