using System;
using System.Text;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter 4-digit number");
            number = int.Parse(Console.ReadLine());
            StringBuilder builder = new(number.ToString());
            void Swap(int i, int j)
            {
                (builder[0], builder[3]) = (builder[3], builder[0]);
            }
            for (int i = 4; i < 5; i++)
            {
                if (i % 2 == 0) Swap(1, 2);
                else Swap(0, 2);
                Console.Write($"{builder,-4} ");
            }
            Console.ReadLine();
        }
    }
}
