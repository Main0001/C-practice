using System.Text.RegularExpressions;

string str = "Приве мир!";
if (Regex.IsMatch(str, "[A-Za-z]")) Console.WriteLine("Ошибка! В строке содержиться латинский символ.");
else
{
    int countSoglasn = Regex.Matches(str, @"[бвгджзйклмнпрстфхцчшщ]", RegexOptions.IgnoreCase).Count;
    var consonats = Regex.Matches(str, @"[бвгджзйклмнпрстфхцчшщ]", RegexOptions.IgnoreCase);
    Console.WriteLine($"Number of consonants {countSoglasn}");
    foreach (var letter in consonats)
    {
        Console.Write(letter + " ");
    }
}