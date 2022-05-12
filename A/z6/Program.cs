using System;

namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            Console.WriteLine("Enter 4-digit number");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine($"Digits sum: {sum}");
        }
    }
}
