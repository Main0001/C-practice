Console.WriteLine("Введите размер матрицы");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

Matrix matrix = new Matrix();
double[,] a = new double[n, m];

matrix.m = m;
matrix.n = n;

Console.WriteLine("Введите элементы матрицы");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = Convert.ToDouble(Console.ReadLine());
    }
        
}


Console.WriteLine("Введите строку");
int b = Convert.ToInt32(Console.ReadLine());

matrix.PrintMatrix(a, b);
matrix.Task(a, b, n, m);
Console.ReadLine();
class Matrix
{
    public int n;
    public int m;
    public void PrintMatrix(double[,] a, int b)
    {
        Console.WriteLine("Ваша матрица");
        for (int i = 0; i < n; i++) // вывод нашей матрицы
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}{1}", a[i, j], "\t");
            }
            Console.WriteLine();
        }

    }
    public void Task(double[,] a, int b, int n)
    {
        double[,] c = new double[n, m];
        Console.WriteLine("Исходная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++) // вычитание элементов в строке
            {
                c[i, j] = a[i, j] - a[b, j];
            }
        }

        for (int j = 0; j < m; j++) // присвоение элементам исходного значения (до вычитания)
        {
            c[b, j] = c[b, j] + a[b, j];
        }

        for (int i = 0; i < n; i++) //вывод полученной матрицы
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}{1}", c[i, j], "\t");
            }
            Console.WriteLine();
        }
    }

    public void Task(double[,] a, int b, int n, int m) //перегрузка методов, беру методы, ибо оператора нормального нет
    {
        double[,] c = new double[n, m];
        Console.WriteLine("Исходная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++) // вычитание элементов в строке
            {
                c[i, j] = a[i, j] - a[b, j];
            }
        }

        for (int j = 0; j < m; j++) // присвоение элементам исходного значения (до вычитания)
        {
            c[b, j] = c[b, j] + a[b, j];
        }

        for (int i = 0; i < n; i++) //вывод полученной матрицы
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}{1}", c[i, j], "\t");
            }
            Console.WriteLine();
        }
    }
}