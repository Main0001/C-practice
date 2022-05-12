using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, multiple, divide;
            int y;
            Console.WriteLine("Enter x value: ");
            Console.WriteLine("Enter y value: ");
            y = int.Parse(Console.ReadLine());
            x = float.Parse(Console.ReadLine());
            multiple = x * 3;
            divide = multiple / y;
            Console.WriteLine($"Rounded to 4 digits value: {Math.Round(multiple, 4)} / {y} = {divide}");
        }
    }
}
