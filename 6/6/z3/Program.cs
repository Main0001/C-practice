using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter any sentence: ");
                string sentence = Console.ReadLine().ToLower();
                string[] letters = sentence.Split(' ');
                if (letters.Length >= 2)
                {
                    var temp = letters[letters.Length - 1];
                    letters[letters.Length - 1] = letters[0];
                    letters[0] = temp;
                    sentence = String.Join(' ', letters);
                    Console.WriteLine(sentence);
                    if (letters.Length >= 3)
                    {
                        sentence = sentence.Remove(sentence.LastIndexOf(' '), 1);
                        Console.WriteLine(sentence);
                        letters = sentence.Split(' ');
                        letters[2] = ReverseWord(letters[2]);
                        sentence = String.Join(' ', letters);
                        Console.WriteLine(sentence);
                    }
                    else { Console.WriteLine("under 3 letters"); }
                }
                if (letters.Length >= 1 && letters[0].Length >= 2)
                {
                    sentence = sentence.Substring(2);
                    Console.WriteLine(sentence);
                }
                else
                {
                    Console.WriteLine("First word is not in correct format(< 2 letters)");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! ({e})");
            }

        }
        static string ReverseWord(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
