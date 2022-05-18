try
{
    Console.Write("Введите размерность массива: ");
    int leng = Convert.ToInt32(Console.ReadLine());

    double[] arr = new double[leng];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 5, 2);
        Console.WriteLine(arr[i]);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 && arr[i] < 3.2)
        {
            Console.WriteLine($"Условию 0<x<3,2 удовлетворяет: {i} элемент массива");
        }
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}