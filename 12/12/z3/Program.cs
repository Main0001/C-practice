using System;

try
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();

    Message msg = ChangeReg;
    msg += Substr;
    msg += Separate;

    msg(str);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
/// <summary>
/// ChangeReg for making Upper case in string
/// </summary>
/// <param name="str">string</param>
void ChangeReg(string str)
{
    Console.WriteLine(str.ToUpper());
}
/// <summary>
/// Substr for displaying string from 2 index
/// </summary>
/// <param name="str">string</param>
void Substr(string str)
{
    Console.WriteLine(str.Substring(2));
}
/// <summary>
/// Separate for separating string with spaces
/// </summary>
/// <param name="str">string</param>
void Separate(string str)
{
    string[] words = str.Split(' ');

    foreach (string word in words)
        Console.WriteLine(word);
}
/// <summary>
/// Delegat for work with string
/// </summary>
/// <param name="str">some text</param>
delegate void Message(string str);
