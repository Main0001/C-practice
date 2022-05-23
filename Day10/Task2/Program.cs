try
{
    Arr[] arr = new Arr[2];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите длину массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите левую границу массива: ");
        int leftBorder = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите правую границу массива: ");
        int rightBorder = Convert.ToInt32(Console.ReadLine());

        arr[i] = new Arr(len, leftBorder, rightBorder);
        arr[i].Fill();
    }

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите индекс элемента: ");
        int index = Convert.ToInt32(Console.ReadLine());
        arr[i].FindElem(index);
    }

    Console.WriteLine();
    arr[0].SubSum(arr);
    Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите индекс элемента: ");
        int index = Convert.ToInt32(Console.ReadLine());
        arr[i].PrintElem(index);
        Console.WriteLine();
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class Arr
{
    int[] mass;
    int leftBorder;
    int rightBorder;

    public Arr(int len, int left, int right)
    {
        mass = new int[len];
        leftBorder = left;
        rightBorder = right;
    }

    Random rnd = new Random();
    public int[] Fill()
    {
        for (int i = 0; i < mass.Length; i++)
            mass[i] = rnd.Next(leftBorder, rightBorder+1);
        return mass;
    }

    public void FindElem(int index)
    {
        if (index >= 0 && index < mass.Length)
            Console.WriteLine(mass[index]);
        else
            Console.WriteLine("Индекс выходит за пределы массива");
    }

    public void SubSum(Arr[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
            if (arr[0].leftBorder == arr[i].leftBorder && arr[0].rightBorder == arr[i].rightBorder)
            {
                int[] sum = arr[0].mass.Length > arr[i].mass.Length ? new int[arr[0].mass.Length] : new int[arr[i].mass.Length];
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = arr[0].mass[j] + arr[i].mass[j];
                    Console.Write(sum[j] + " ");
                }
                
                Console.WriteLine();

                int[] sub = arr[0].mass.Length > arr[i].mass.Length ? new int[arr[0].mass.Length] : new int[arr[i].mass.Length];
                for (int j = 0; j < sub.Length; j++)
                {
                    sub[j] = arr[0].mass[j] - arr[i].mass[j];
                    Console.Write(sub[j] + " ");
                }
            }
    }

    public void PrintElem(int index)
    {
        Console.WriteLine(mass[index]);
        for (int i = 0; i < mass.Length; i++)
            Console.Write(mass[i] + " ");
    }
}