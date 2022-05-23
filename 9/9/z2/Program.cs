using System;

namespace new_V4_p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, choose = 1;
            Console.WriteLine("Enter matrix dimensions (N x M): ");
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            Matrix matrix = new Matrix(N, M);//Создали матрицу

            Console.WriteLine("fill matrix: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = Double.Parse(Console.ReadLine());
                }
            }

            while (choose != 5)
            {
                Console.WriteLine("Choose operation:\n 1 - Print matrix\n 2 - Print submatrix\n 3 - Change matrix \n 4 - Get value\n 5 - Exit\nEnter number: ");
                string choice = Console.ReadLine();
                choose = Convert.ToInt32(choice);
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("=====Matrix=====");
                            matrix.Print();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("=====Submatrix=====");
                            Console.WriteLine("Enter coordinates: ");
                            matrix.Print1();
                            Console.WriteLine();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Enter dimensions (N x M): ");
                            N = int.Parse(Console.ReadLine());
                            M = int.Parse(Console.ReadLine());
                            matrix = new Matrix(N, M);
                            Console.WriteLine("Fill matrix: ");
                            for (int i = 0; i < N; i++)
                            {
                                for (int j = 0; j < M; j++)
                                {
                                    matrix[i, j] = Double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter coordinates: ");
                            N = int.Parse(Console.ReadLine());
                            M = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Value: {matrix[N, M]}");
                            break;
                        }
                }
            }
            Console.ReadLine();

        }
    }
}
class Matrix
{
    private double[,] matrix;
    private int N, M;

    public Matrix()
    {
        matrix = new Double[0, 0];
        this.N = 0;
        this.M = 0;
    }
    public Matrix(int N, int M)
    {
        matrix = new Double[N, M];
        this.N = N;
        this.M = M;
    }

    public int iN
    {
        get
        {
            return N;
        }
        set
        {
            this.N = value;
        }
    }
    public int iM
    {
        get
        {
            return M;
        }
        set
        {
            this.M = value;
        }
    }

    public double this[int x, int y]
    {

        set
        {
            if (N >= x && M >= y && x >= 0 && y >= 0)
            {
                matrix[x, y] = value;
            }
            else
            {
                Console.WriteLine("Invalid coordinate!");
                matrix[x, y] = 0;
            }

        }
        get
        {
            if (N >= x && M >= y && x >= 0 && y >= 0)
            {
                return matrix[x-1, y-1];
            }
            else
            {
                Console.WriteLine("Invalid coordinate!");
                return 0;
            }
        }
    }
    public void Print()
    {
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < M; j++)
            {
                Console.Write(" {0} ", matrix[i, j]);
            }
        }
        Console.WriteLine();
    }
    public void Print1()
    {
        int r = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Submatrix: ");
        if (r <= N && s <= N)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}