try
{
    int[] arr = new int[15];
    int jPosition = 0;
    int max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        Random r = new Random();
        arr[i] = r.Next(1, 30);
    }

    Console.WriteLine("Начальный массив:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            jPosition = i;
        }
    }
    Console.WriteLine($"\nmax = {max}");

    arr[jPosition] = arr[0];
    arr[0] = max;

    Console.WriteLine("\nResult:");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}