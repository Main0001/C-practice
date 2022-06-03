using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Delegat for array elements
    /// </summary>
    /// <returns>value of array element</returns>
    public delegate int Number();
    /// <summary>
    /// Delegat for medium
    /// </summary>
    /// <param name="arrayX">array</param>
    /// <returns>mean</returns>
    public delegate double MediumCalc(Number[] arrayX);
    class Program
    {
        static Random rand = new Random();
        public static int Randomizer() //функция рандома
        {
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Number[] numArr = new Number[5]; //создание массива через анонимную функцию
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer; // генерация рандомных чисел в массиве
            }

            MediumCalc mediumCalc = delegate (Number[] arrayX) //выполнение анонимной функции
            {
                var arrayT = new int[5];
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayT[i] = arrayX[i](); //присваимваем элементам нового массива arrayT, т.к. если проосто прибавлять arrayX[i](), то будут рандомиться новые числа в массиве arrayX, следовательно среднее арифметическое будет неправильным
                    sum += arrayT[i];
                    Console.Write(arrayT[i] + " ");
                }
                return ((double)(sum) / (arrayX.Length));
            };

            Console.WriteLine($"\nResult = {mediumCalc(numArr)}"); //вызов анонимной функции

            Console.ReadLine();
        }
    }
}