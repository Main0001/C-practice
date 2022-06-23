using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Меню:");
            Console.WriteLine("0 - Выйти из программы");
            Console.WriteLine("1 - Вывести на экран все компоненты файла,меньшие заданного числа.");
            Console.WriteLine("2 - Вывести на экран все положительные компоненты файла");
            Console.WriteLine("3 - Вычислить среднее арифметическое компонентов файла, стоящих\nна чётных позициях");
            Console.WriteLine();
        }

        static void Task1(BinaryReader fromFile)
        {
            double userNum; 
            double item; 

            do
            {
                Console.Write("Введите опорное число: ");
                try
                {
                    userNum = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных.");
                }
            } while (true);

            Console.WriteLine("Числа, меньшие заданного вами:");
            try
            {
                fromFile.BaseStream.Seek(0, SeekOrigin.Begin);
                while (fromFile.BaseStream.Position < fromFile.BaseStream.Length)
                {
                    item = fromFile.ReadDouble();
                    if (item < userNum) Console.WriteLine(item);
                }

            }
            catch (IOException A)
            {
                Console.WriteLine("Внимание! Возникло исключение при чтении файла.\n" + A.Message);
            }
        } 

        static void Task2(BinaryReader fromFile) 
        {
            double item; 
            Console.WriteLine("Положительные компоненты файла:");
            try
            {
                fromFile.BaseStream.Seek(0, SeekOrigin.Begin);
                while (fromFile.BaseStream.Position < fromFile.BaseStream.Length)
                {
                    item = fromFile.ReadDouble();
                    if (item > 0.0) Console.WriteLine(item);
                }

            }
            catch (IOException A)
            {
                Console.WriteLine("Внимание! Возникло исключение при чтении файла.\n" + A.Message);
            }
        } 

        static void Task3(BinaryReader fromFile) 
        {
            int i = 0;
            double summ = 0.0;
            double item; 

            Console.WriteLine("Среднее арифметическое компонентов файла, стоящих на чётных позициях:");
            try
            {
                fromFile.BaseStream.Seek(0, SeekOrigin.Begin);
                while (fromFile.BaseStream.Position < fromFile.BaseStream.Length)
                {
                    item = fromFile.ReadDouble();
                    summ += item; 
                    i++; 
                    fromFile.BaseStream.Position += 8;  
                }
            }
            catch (IOException A)
            {
                Console.WriteLine("Внимание! Возникло исключение при чтении файла.\n" + A.Message);
            }
  
            Console.WriteLine("{0:F3}", summ / i);
        } 

        static void Main(string[] args)
        {
            int i = 0; 
            int seqLength = 0; 

            double currNum;
            double[] arr; 

            string fileName = "output.dat"; 
            FileStream fs; 
            BinaryWriter dataOut; 
            BinaryReader dataIn; 


            Console.WriteLine("Ввод последовательности из n вещественных чисел:");

            do 
            {
                Console.Write("Укажите длину последовательности: ");
                try
                {
                    seqLength = int.Parse(Console.ReadLine());
                    if (seqLength <= 0) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных.");
                }
            } while (seqLength <= 0); 

            arr = new double[seqLength]; 

            do 
            {
                Console.Write("[{0}]: ", i);
                try
                {
                    currNum = double.Parse(Console.ReadLine());
                    arr[i] = currNum;
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных.");
                }
            } while (i < arr.Length); 
            Console.WriteLine("Полученная последовательность:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]); 
            } 


            try 
            {

                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                dataOut = new BinaryWriter(fs);
            }
            catch (IOException A)
            {
                Console.WriteLine("Внимание! Возникло исключение при открытии файла {0}.", fileName);
                Console.WriteLine(A.Message);
                Console.WriteLine("Аварийное завершение программы.");
                return;
            }

            try 
            {
                for (i = 0; i < arr.Length; i++)
                {
                    dataOut.Write(arr[i]);
                }
                Console.WriteLine("Файл записан.");
            }
            catch (IOException B)
            {
                Console.WriteLine("Внимание! Возникло исключение при записи файла.\n" + B.Message);
            }
            finally
            {
                dataOut.Close(); 
            }
            try 
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                dataIn = new BinaryReader(fs);
            }
            catch (IOException C)
            {
                Console.WriteLine("Внимание! Возникло исключение при открытии файла {0}.", fileName);
                Console.WriteLine(C.Message);
                Console.WriteLine("Аварийное завершение программы.");
                return;
            }

            ShowMenu(); 
            bool IsExit; 
            byte itemMenu;

            try 
            {
                do 
                {
                    IsExit = false;

                    try 
                    {
                        Console.WriteLine("Введите номер пункта меню");
                        itemMenu = byte.Parse(Console.ReadLine());
                        switch (itemMenu) 
                        {
                            case 0:
                                IsExit = true;
                                break;
                            case 1:
                                Task1(dataIn);
                                break;
                            case 2:
                                Task2(dataIn);
                                break;
                            case 3:
                                Task3(dataIn);
                                break;
                            default:
                                Console.WriteLine("Нет такого пункта меню.");
                                break;
                        } 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка! Неверный формат при вводе пункта меню.");
                    }

                } while (!IsExit);
            }
            finally
            {
                dataIn.Close();
            }
            Console.WriteLine("Конец программы");

        } 
    }
}