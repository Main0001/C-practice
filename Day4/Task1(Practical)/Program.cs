try
{
    int rowCount = 5;
    int colCount = 5;

    Matrix mass = new Matrix(5, 5);
    Console.WriteLine("Сгенерировать стандартную матрицу? (y/n)");
    char choice = Convert.ToChar(Console.ReadLine());
    if (choice == 'y')
    {
        mass.MatrixInit();
    }
    else if (choice == 'n')
    {
        Console.Write("Введите количество строк матрицы: ");
        rowCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        colCount = Convert.ToInt32(Console.ReadLine());

        mass = new Matrix(rowCount, colCount);
        mass.MatrixInit(rowCount, colCount);
    }

    for (int i = 0; i < mass.matr.GetLength(0); i++)
    {
        for (int j = 0; j < mass.matr.GetLength(1); j++)
            Console.Write($"{mass.matr[i, j]}\t");
        Console.WriteLine();
    }

    Console.WriteLine($"Результат умножения положительных элементов массива больше 10 = {mass.MultLess10()}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Matrix
{
    public int[,] matr { get; set; }
    public int rCount;
    public int cCount;
    private int _result = 1;

    public Matrix(int rowCount, int colCount)
    {
        this.rCount = rowCount;
        this.cCount = colCount;
    }

    Random rand = new Random();
    public void MatrixInit()
    {
        matr = new int[rCount, cCount];
        for (int i = 0; i < rCount; i++)
        {
            for (int j = 0; j < cCount; j++)
            {
                matr[i, j] = rand.Next(30);
            }
        }
    }

    public void MatrixInit(int rowCount, int colCount)
    {
        matr = new int[rowCount, colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                matr[i, j] = rand.Next(30);
            }
        }
    }

    public int MultLess10()
    {
        return matr.Cast<int>().Where(x => x > 0 && x < 10).Aggregate((a, b) => a * b);
    }
}