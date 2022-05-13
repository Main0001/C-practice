using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter value: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Value is incorrect!");
                }
            }
            switch (number)
            {
                case 1:
                case 2:
                case 9:
                    Console.WriteLine("Backetball");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Run");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Barbell");
                    break;
                default:
                    break;
            }
        }
    }
}
