using System.Text.RegularExpressions;

namespace LW5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hellow world, it's new world!";

            Regex regExStart = new Regex(@"^\w+", RegexOptions.IgnoreCase);
            Regex regExEnd = new Regex(@"\S+$", RegexOptions.IgnoreCase);

            MatchCollection matches = regExStart.Matches(text);
            MatchCollection matchesEnd = regExEnd.Matches(text);

            foreach (Match statrWord in matches) { Console.WriteLine("Первое слово'{0}'", statrWord.Value); }
            foreach (Match endWord in matchesEnd) { Console.WriteLine("Конечное слово'{0}'", endWord.Value); }

            Console.ReadLine();
        }
    }
}
