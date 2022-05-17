class Array
{
    private double[,] _data;
    public int RowCount => _data.GetLength(0);
    public int ColumnCount => _data.GetLength(1);
    public double this[int x, int y]
    {
        get { if (x < 0 || x > RowCount || y < 0 || y > ColumnCount) { throw new Exception(); } return _data[x, y]; }
        set { _data[x, y] = value; }

    }

    public Array(int dim1, int dim2)
    {
        _data = new double[dim1, dim2];
    }
    public void Print()
    {
        for (int i = 0; i < RowCount; i++)
        {
            for (int j = 0; j < ColumnCount; j++)
            {
                Console.Write(_data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public int GetLength(int d)
    {
        return _data.GetLength(d);
    }

    public double GetValue(int i1, int i2)
    {
        return _data[i1, i2];
    }

    public void SetValue(int i1, int i2, int val)
    {
        _data[i1, i2] = val;
    }

    //public static bool operator <(Array a1, Array a2)
    //{
    //    int min1 = Math.Min(a1.GetLength(0), a1.GetLength(1));
    //    double sum1 = 0;
    //    for (int i1 = 0; i1 < min1; i1++)
    //        sum1 += a1.GetValue(i1, i1);

    //    int min2 = Math.Min(a2.GetLength(0), a2.GetLength(1));
    //    double sum2 = 0;
    //    for (int i2 = 0; i2 < min2; i2++)
    //        sum2 += a2.GetValue(i2, i2);

    //    return sum1 < sum2;
    //}

    //public static bool operator >(Array a1, Array a2)
    //{
    //    int min1 = Math.Min(a1.GetLength(0), a1.GetLength(1));
    //    double sum1 = 0;
    //    for (int i1 = 0; i1 < min1; i1++)
    //        sum1 += a1.GetValue(i1, i1);

    //    int min2 = Math.Min(a2.GetLength(0), a2.GetLength(1));
    //    double sum2 = 0;
    //    for (int i2 = 0; i2 < min2; i2++)
    //        sum2 += a2.GetValue(i2, i2);

    //    return sum1 > sum2;
    //}
    public static Array operator +(Array array, int index)
    {
        if (index < 0 || index > array.ColumnCount)
        {
            throw new ArgumentException();
        }
        for (int i = 0; i < array.RowCount; i++)
        {
            array[i, 0] += array[i, index];
        }
        return array;
    }
}
class Temp
{
    static void Main(string[] args)
    {
        Console.Write("Создаём двумерный массив [{0},{1}]...", 5, 5);
        Array array1 = new Array(5, 5);
        Console.Write("\nСоздаём двумерный массив [{0},{1}]...", 5, 5);
        Array array2 = new Array(5, 5);
        Console.WriteLine("\n");

        int min = -10, max = 10;
        Random r = new Random();        
        Console.WriteLine("Заполняем массив 1 случайными числами из отрезка [{0},{1}]", min, max);
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1.SetValue(i, j, r.Next(min, max));
                Console.Write("{0,3} ", array1.GetValue(i, j));
            }
            Console.WriteLine();
        }
        Console.WriteLine("Заполняем массив 2 случайными числами из отрезка [{0},{1}]", min, max);
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2.SetValue(i, j, r.Next(min, max));
                Console.Write("{0,3} ", array2.GetValue(i, j));
            }
            Console.WriteLine();
        }

        Console.WriteLine("Добавление 4-ого столбца к первому для перваго массива: ");
        array1 += 4;
        array1.Print();
        Console.WriteLine();
    }
}
