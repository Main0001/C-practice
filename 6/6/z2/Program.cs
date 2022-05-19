using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1;
            int c = 0;
            Console.Write("Enter any sentece: ");
            s = Console.ReadLine();
            Console.Write("Enter word: ");
            s1 = Console.ReadLine();
            string[] ss = s.Split(' ');
            foreach (var str in ss)
            {
                if (str == s1)
                {
                    ++c;
                }
            }
            Console.WriteLine($"Amount of words: {Convert.ToString(c)}");
        }
    }
}
