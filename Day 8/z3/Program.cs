using System.Text.RegularExpressions;

string st = Console.ReadLine();
Console.WriteLine((Regex.IsMatch(st, @"\d")) ? "Содержит" : "Неа");
