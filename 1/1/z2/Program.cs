using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3-digit value:");
            string str = Console.ReadLine();
            if (str.Substring(0, 1) == str.Substring(1, 1) && str.Substring(1, 1) == str.Substring(1, 1))
            {
                Console.WriteLine("digits in number are the same");
            }
            else Console.WriteLine("digits are not the same");
        }
    }
}
