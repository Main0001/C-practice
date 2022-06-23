using System.Text;
using System.Text.RegularExpressions;

string str = @"text.txt";

List<string> PaymentInf = new List<string>();

string[] Payments = File.ReadAllLines(str, Encoding.Default);

for (int x = 0; x < Payments.Length; x++)
{
    Console.WriteLine($"Входная строка: {Payments[x]}");

    var tttt = Payments[x].Split(new[] { ',', ' ', '-', '.' }).ToList();

    char letter = 'l';

    var res = Regex.Matches(Payments[x], "\\b" + letter + @"\w*(-\w+)*", RegexOptions.IgnoreCase).Cast<Match>().Select(i => i.Value).ToArray();

    Console.WriteLine($"Слова, начинающиеся на символ {letter}:");

    Console.WriteLine(string.Join("\r\n", res));

    PaymentInf.Add(Payments[x]);
}

int len = 3;

Console.WriteLine($"Слова, имеющие длину {len} символа(ов):");

foreach (string R in PaymentInf)
{
    string[] mas = R.Split(new Char[] { ' ', ',', '.' });

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length == len)
        {
            Console.WriteLine(mas[i]);
        }
    }
} 
Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");

foreach (string R in PaymentInf)
{
    string[] slova = R.Split(' ', ',', '.', '-');

    foreach (string slovo in slova)
    {
        if (slovo.Length > 1)
        {
            if (slovo[0] == slovo[slovo.Length - 1])
            {
                Console.WriteLine(slovo);
            }
        }

    }
}
Console.WriteLine($"Слова, начинающиеся на ту же букву, что и последнее слово:");
foreach (string R in PaymentInf)
{
    string lastWord = R.Split(' ', ',', '.', '-').Last();

    var matches = Regex.Matches(R, @"\b[\w]+\b", RegexOptions.Compiled);

    var lastMatch = matches.Cast<Match>().Last();

    string lastRemoved = R.Remove(lastMatch.Index, lastMatch.Length);

    string[] slova = lastRemoved.Split(' ', ',', '.', '-');

    foreach (string slovo in slova)
    {
        if (slovo.Length > 1)
        {
            if (slovo[0] == lastWord[0])
            {
                Console.WriteLine(slovo);
            }
        }

    }
}
