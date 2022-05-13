
using System;

namespace z7
{
    class Program
    {
        static void Main(string[] args)
        {;
            double firstNumber = 0, secondNumber = 0;
            while (true)
            {
                try
                {
                    Console.Write("First value: ");
                    firstNumber = Math.Abs(double.Parse(Console.ReadLine()));
                    Console.Write("Second value: ");
                    secondNumber = Math.Abs(double.Parse(Console.ReadLine()));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is incorrect!");
                }
            }
            Console.WriteLine($"Avarage - {(firstNumber + secondNumber) / 2}");
            Console.WriteLine($"Geometric mean - {(firstNumber * secondNumber) / 2}");
        }
    }
}
