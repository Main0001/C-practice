Console.Write("Enter n: ");
int N = int.Parse(Console.ReadLine());

int[,] array = new int[N, N];

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
        array[i, j] = random.Next(a, b);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


if (arrayParser(array)) { Console.WriteLine("First"); }
else { Console.WriteLine("Penultimate"); }

static bool arrayParser(int[,] array)
{
    int firstSum = 0, penultimateSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) { firstSum += array[i, j]; }
            if (i == array.GetLength(1) - 2) { penultimateSum += array[i, j]; }
        }
    }
    return firstSum > penultimateSum;
}