using System;

namespace add_on
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 7;
            const int z = 7;
            int[,] array = new int[x, z];

            int row = 0;
            int column = 0;
            int diagonalX = 1;
            int diagonalY = 0;
            int Changes = 0;
            int visit = z;

            for (int i = 0; i < array.Length; i++)
            {
                array[row, column] = i + 1;
                if (--visit == 0)
                {
                    visit = z * (Changes % 2) + x * ((Changes + 1) % 2) - (Changes / 2 - 1) - 2;
                    int temp = diagonalX;
                    diagonalX = -diagonalY;
                    diagonalY = temp;
                    Changes++;
                }

                column += diagonalX;
                row += diagonalY;
            }

            Console.WriteLine("Spiral two dimensional array:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write($"{array[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
