using System;
using System.Linq;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter string: ");
                string sentence = Console.ReadLine().ToLower();
                sentence = Delete(sentence).Trim();
                string[] letters = sentence.Split(' ');
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i].Length == 1)
                    {
                        letters[i] = "";
                    }
                }
                sentence = String.Join(' ', letters).Trim();
                Console.WriteLine(Delete(sentence));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! ({e})");
            }
        }

        static string Delete(string s, int k = 1)
        {
            char[] rs = new char[] { ' ', '(', '[', '{' };
            if (k >= s.Length)
            {
                if (s[k - 1] == ' ') s = s.Remove(k - 1, 1);
                return s;
            }
            else
            {
                if ((s[k] == ' ') && (rs.Contains(s[k - 1])))
                {
                    s = s.Remove(k, 1);
                }
                else
                {
                    k++;
                }
                return Delete(s, k);
            }
        }
    }
}
