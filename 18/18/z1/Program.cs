using System;
using System.Collections.Generic;
using System.Linq;

try
{
    Console.WriteLine("Enter text (symbol # - deleting symbol): ");
    string text = Console.ReadLine();
    var StackText = new Stack<char>();

    for (int i = 0; i < text.Length; i++)
        StackText.Push(text[i]);
    Console.WriteLine(DeleteLetters(StackText));
}

catch (Exception e)
{
    Console.WriteLine($"An error occured - {e.Message}");
}

string DeleteLetters(Stack<char> text)
{
    string textD = string.Empty;
    int i = 0;

    while (text.Count > 0)
    {
        char c = text.Pop();
        if (c == '#')
            i++;
        else if (i > 0)
            i--;
        else textD += c;
    }
    char[] letters = new char[textD.Length];
    letters = textD.Select(x => x).ToArray();
    Array.Reverse(letters);
    textD = new string(letters);

    return textD;
}