using System;
using System.Text.RegularExpressions;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any text: ");
            string text = Console.ReadLine();
            Console.Write("Enter word: ");
            string search = Console.ReadLine();

            int count = new Regex(search).Matches(text).Count;

            Console.WriteLine($"The word is included in the sentence {count} times");
        }
    }
}
