try
{
    int[] arr = new int[100];
    int temp;
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        Random r = new Random();
        arr[i] = r.Next(1, 1000);
    }

    Console.WriteLine("Начальный массив:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    Console.WriteLine("\nСортированный массив:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }

    int n = arr.Length;
    int center = n / 2;

    for (int i = 0; i < center; i++)
    {
        temp = arr[i];
        arr[i] = arr[n - i - 1];
        arr[n - i - 1] = temp;
    }

    Console.WriteLine("\nИнверсия массива:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine("\nИнверсия массива (вывод в строке 6 чисел):");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
        count++;
        if (count == 6)
        {
            count = 0;
            Console.WriteLine();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}