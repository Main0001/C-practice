using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public class MyArray : ICloneable
    {

        private int firstIndex, lastIndex;
        string[] arr;

        public MyArray(int firstIndex, int lastIndex)
        {

            if (firstIndex >= lastIndex)
                throw new ArgumentException("первый индекс должен быть меньше последнего");
            this.firstIndex = firstIndex;
            this.lastIndex = lastIndex;
            arr = new string[lastIndex - firstIndex + 1];
        }

        public int FirstIndex
        {
            get { return firstIndex; }
        }

        public int LastElemPos
        {

            get { return arr.Length + firstIndex; }
        }

        public string this[int pos]
        {
            get
            {
                if (pos < firstIndex || pos > lastIndex)
                    throw new ArgumentOutOfRangeException("Вышли за границы массива :(");
                else
                    return arr[pos - firstIndex];
            }
            set
            {
                if (pos < firstIndex || pos > lastIndex)
                    throw new ArgumentOutOfRangeException("Вышли за границы массива :(");
                else
                    arr[pos - firstIndex] = value;
            }
        }


        public object Clone()
        {
            MyArray copy = new MyArray(this.firstIndex, this.lastIndex);
            for (int i = 0; i < copy.arr.Length; i++)
            {
                copy.arr[i] = this.arr[i];
            }
            return copy;
        }





        public static MyArray Concat(MyArray arr1, MyArray arr2)
        { 
            MyArray temp1 = (MyArray)arr1.Clone();
            MyArray temp2 = (MyArray)arr2.Clone();

            int temp = temp1.arr.Length;
            Array.Resize(ref temp1.arr, temp1.arr.Length + temp2.arr.Length);
            temp1.lastIndex += temp2.arr.Length;
            temp2.arr.CopyTo(temp1.arr, temp);
            return temp1;

        }


        public static MyArray Merge(MyArray pArr1, MyArray pArr2)
        {
            MyArray arr1 = (MyArray)pArr1.Clone();
            MyArray arr2 = (MyArray)pArr2.Clone();

            int sizeForAdd = arr2.arr.Length;
            for (int i = 0; i < arr1.arr.Length; i++)
            {
                for (int j = 0; j < arr2.arr.Length; j++)
                {
                    if (arr1.arr[i] == arr2.arr[j]) 
                    {
                        arr2.arr[j] = null;
                        sizeForAdd--;
                    }
                }
            }

            int temp = arr1.arr.Length;
            Array.Resize(ref arr1.arr, arr1.arr.Length + sizeForAdd);

            for (int i = 0; i < arr2.arr.Length; i++)
            {
                if (arr2.arr[i] != null)
                {
                    arr1.arr[temp] = arr2.arr[i];
                    temp++;
                }
            }

            arr1.lastIndex += sizeForAdd;
            return arr1;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);

            MyArray arr = new MyArray(-2, 3);

            MyArray arr2 = new MyArray(1, 5);



            for (int i = arr.FirstIndex; i < arr.LastElemPos; i++)
            {
                arr[i] = "строка массива " + i;
            }

            for (int i = arr2.FirstIndex; i < arr2.LastElemPos; i++)
            {
                arr2[i] = "строка массива " + i;
            }

            Console.WriteLine("Все элементы первого массива");
            for (int i = arr.FirstIndex; i < arr.LastElemPos; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Все элементы второго массива");
            for (int i = arr2.FirstIndex; i < arr2.LastElemPos; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Элемент с индексом -1 первого массива - {0}", arr[-1]);
            Console.WriteLine();


            MyArray concatArr = MyArray.Concat(arr, arr2);
            Console.WriteLine("Объединенный массив");

            for (int i = concatArr.FirstIndex; i < concatArr.LastElemPos; i++)
            {
                Console.WriteLine(concatArr[i]);
            }
            Console.WriteLine();


            MyArray MergeArr = MyArray.Merge(arr, arr2);

            Console.WriteLine("объединенный массив с уникальными элементами");

            for (int i = MergeArr.FirstIndex; i < MergeArr.LastElemPos; i++)
            {
                Console.WriteLine(MergeArr[i]);
            }

            Console.ReadLine();

        }
    }
}
