using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Matrix
    {
        double[,] matrix;
        int Row = 0, Col = 0;

        public Matrix(int row, int col)
        {
            matrix = new double[row, col];
            Row = row; Col = col;
        }

        public Matrix(int N)
        {
            matrix = new double[N, N];
            Row = Col = N;
        }

        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        //Ovverride
        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] + second[i, j];
            return mat;
        }

        //Ovverride
        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix mat = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
                for (int j = 0; j < first.Col; j++)
                    mat[i, j] = first[i, j] - second[i, j];
            return mat;
        }

        //* Number
        public static Matrix operator *(Matrix m, int t)
        {
            Matrix mat = new Matrix(m.Row, m.Col);
            for (int i = 0; i < m.Row; i++)
                for (int j = 0; j < m.Col; j++)
                    mat[i, j] = m[i, j] * t;
            return mat;
        }

        //Display
        public void PrintMatrix()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }

        }

        //***
        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix matr = new Matrix(first.Row, first.Col);
            for (int i = 0; i < first.Row; i++)
            {
                for (int j = 0; j < second.Col; j++)
                {
                    double sum = 0;
                    for (int r = 0; r < first.Col; r++)
                        sum += first[i, r] * second[r, j];
                    matr[i, j] = sum;
                }
            }
            return matr;
        }

        //POW
        public static Matrix operator ^(Matrix first, int pow)
        {
            Matrix matr = new Matrix(first.Row, first.Col);
            matr = first;
            for (int z = 1; z < pow; z++)
            {
                Matrix bufer = new Matrix(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Row; j++)
                    {
                        double sum = 0;
                        for (int r = 0; r < first.Row; r++)
                            sum += matr[i, r] * first[r, j];
                        bufer[i, j] = sum;
                    }
                }
                matr = bufer;
            }
            return matr;
        }
    }

    static void Main(string[] args)
    {

        int N = 3;

        int pow = 3;

        Random rand = new Random();
        Matrix first = new Matrix(N);
        Matrix second = new Matrix(N);

        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
            {
                first[i, j] = rand.Next(1, 4);
                second[i, j] = rand.Next(1, 4);
            }

        Console.WriteLine("Первая матрица:\n\n");
        first.PrintMatrix();
        Console.WriteLine("\n\nВторая матрица:\n\n");
        second.PrintMatrix();
        Console.WriteLine("\n\nСумма матриц:\n\n");
        (first + second).PrintMatrix();
        Console.WriteLine("\n\nРазница матриц:\n\n");
        (first - second).PrintMatrix();
        Console.WriteLine("\n\nУмножение на число:\n\n");
        (first * 3).PrintMatrix();
        Console.WriteLine("\n\nПроизведение матриц:\n\n");
        (first * second).PrintMatrix();
        Console.WriteLine("\n\n{0} Степень матрицы:\n\n", pow);
        (first ^ pow).PrintMatrix();
        Console.ReadKey();
    }
}