using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

string str = @"file.txt";

List<string> PaymentInf = new List<string>();

string[] Payments = File.ReadAllLines(str, Encoding.Default);

for (int x = 0; x < Payments.Length; x++)
{
    Console.WriteLine($"Входная строка: {Payments[x]}");

    var a = Payments[x].Split(new[] { ',', ' ', '-', '.' }).ToList();

    char letter = 'l';

    var res = Regex.Matches(Payments[x], "\\b" + letter + @"\w*(-\w+)*", RegexOptions.IgnoreCase).Cast<Match>().Select(i => i.Value).ToArray();

    Console.WriteLine($"Слова, начинающиеся на символ {letter}:");

    Console.WriteLine(string.Join("\r\n", res));

    PaymentInf.Add(Payments[x]);
}

int length = 3;

//2) вывести на экран все слова, длина которых равна заданному числу.
Console.WriteLine($"Слова, имеющие длину {length} символа(ов):");

foreach (string R in PaymentInf)
{
    string[] mas = R.Split(new Char[] { ' ', ',', '.' });

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length == length)
        {
            Console.WriteLine(mas[i]);
        }
    }
}
//3) вывести на экран все слова, которые начинаются и заканчиваются одной буквой. 
Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");

foreach (string R in PaymentInf)
{
    string[] words = R.Split(' ', ',', '.', '-');

    foreach (string word in words)
    {
        if (word.Length > 1)
        {
            if (word[0] == word[word.Length - 1])
            {
                Console.WriteLine(word);
            }
        }

    }
}
//4) вывести на экран все слова, которые начинаются на ту же букву, что и последнее слово. 
Console.WriteLine($"Слова, начинающиеся на ту же букву, что и последнее слово:");
foreach (string R in PaymentInf)
{
    string lastWord = R.Split(' ', ',', '.', '-').Last();

    var matches = Regex.Matches(R, @"\b[\w]+\b", RegexOptions.Compiled);

    var lastMatch = matches.Cast<Match>().Last();

    string lastRemoved = R.Remove(lastMatch.Index, lastMatch.Length);

    string[] words = lastRemoved.Split(' ', ',', '.', '-');

    foreach (string word in words)
    {
        if (word.Length > 1)
        {
            if (word[0] == lastWord[0])
            {
                Console.WriteLine(word);
            }
        }

    }
}
