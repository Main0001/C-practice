using System.Text.RegularExpressions;

try
{
    string s = Console.ReadLine();
    Regex regex = new Regex(@"([а-яА-Я]*[кнгшщзхфвпрлдчсмтжб]{3,}[а-яА-Я]*)", RegexOptions.IgnoreCase);
    MatchCollection matches = regex.Matches(s);
    if (matches.Count > 0)
    {
        foreach (Match match in matches)
            Console.WriteLine(match.Groups[1]);
    }
    else
    {
        Console.WriteLine("Совпадений не найдено");
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}