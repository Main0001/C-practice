Console.Write("Enter n: ");
int N = int.Parse(Console.ReadLine());

int[,] matrix = new int[N, N];

int a, b;
Console.Write("Enter a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = int.Parse(Console.ReadLine());
Random random = new Random();
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = random.Next(a, b);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"SR = {Arithmetic(matrix, 5)}");

Console.Write("Enter k: ");
int k = int.Parse(Console.ReadLine());

Console.WriteLine(matrixParser(matrix, k));

static int matrixParser(int[,] matrix, int k)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, k];
    }
    return sum;
}

static double Arithmetic(int[,] matrix, int G)
{
    int sr = 0;
    int indexer = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > G)
            {
                sr += matrix[i, j];
                indexer++;
            }
        }
    }
    return sr / indexer;
}