using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, multiple, divide;
            int y;
            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            multiple = x * 3;
            divide = multiple / y;
            Console.WriteLine($"Rounded to 4 digits value: {multiple} / {y} = {Math.Round(divide, 4)}");
        }
    }
}
