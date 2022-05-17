using System;

namespace z4
{
    class Array
    {
        private int[,] _data;
        public int RowCount => _data.GetLength(0);
        public int ColumnCount => _data.GetLength(1);
        public int this[int x, int y]
        {
            get { if (x < 0 || x > RowCount || y < 0 || y > ColumnCount) { throw new Exception(); } return _data[x, y]; }
            set { _data[x, y] = value; }

        }

        public Array(int dim1, int dim2)
        {
            _data = new int[dim1, dim2];
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

        public double RemainderSumDevision(int number)
        {
            double remainderSum = 0;
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    remainderSum += Math.Abs(this.GetValue(i, j)) % number;
                }
            }
            return remainderSum;
        }
    }
    class Temp
    {
        static void Main(string[] args)
        {
            Console.Write("Forming two-dimensional array[{0},{1}]...", 10, 10);
            Array array1 = new Array(10, 10);
            Console.Write("\nCreating two-dimensional array[{0},{1}]...", 10, 10);
            Array array2 = new Array(10, 10);
            Console.WriteLine("\n");
            int min = -10, max = 10;
            Random r = new Random();
            Console.WriteLine("Filling first array [{0},{1}]", min, max);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1.SetValue(i, j, r.Next(min, max));
                    Console.Write("{0,3} ", array1.GetValue(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Filling second array [{0},{1}]", min, max);
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2.SetValue(i, j, r.Next(min, max));
                    Console.Write("{0,3} ", array2.GetValue(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Remainder of division on 7: {array1.RemainderSumDevision(7)}");
        }
    }
}