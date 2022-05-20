using System;
using System.Text.RegularExpressions;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentence: ");
            string input = Console.ReadLine();

            Console.Write("Enter the length of a word: ");
            int length = int.Parse(Console.ReadLine());

            var words = Regex.Matches(input, @"\b\w{" + length + @"}\b");
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
        }
    }
}
