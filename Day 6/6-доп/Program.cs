//const int n = 7;
//var a = GetSpire(n);
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write($"{a[i, j],3}");
//    }
//    Console.WriteLine();
//}


//static int[,] GetSpire(int n)
//{
//    int indexer = 0;
//    var result = new int[n, n];
//    for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
//    {
//        for (int j = padding; j < n - padding; j++)
//        {
//            result[padding, j] = indexer;
//            indexer++;
//        }
//        for (int j = padding; j < n - padding; j++)
//        {
//            result[n - padding - 1, j] = indexer;
//            indexer++;
//        }
//        for (int i = padding + 2; i < n - padding - 1; i++)
//        {
//            result[i, padding] = indexer;
//            indexer++;
//        }
//        for (int i = padding + 1; i < n - padding - 1; i++)
//        {
//            result[i, n - padding - 1] = indexer;
//            indexer++;
//        }
//        result[padding + 1, padding] = indexer;
//        indexer++;
//    }
//    if (n % 2 != 0 && result[0, 0] == 1)
//        result[n / 2, n / 2] = 1;
//    return result;
//}

const int n = 7;
const int m = 7;
int[,] matrix = new int[n, m];

int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, col] = i + 1;
    if (--visits == 0)
    {
        visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }

    col += dx;
    row += dy;
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine();
}