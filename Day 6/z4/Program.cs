int[,] array = new int[23,40];
Random rnd = new Random();

for (int i = 0; i < 23; i++)
{
    for (int j = 0; j < 40; j++)
    {
        array[i, j] = rnd.Next(0, 1);
    }
}
