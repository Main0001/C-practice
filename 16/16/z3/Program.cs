using System;
using System.IO;
using System.Linq;

try
{
    string file = @"file.txt";

    using (StreamReader reader = new StreamReader(file))
    {
        PrintFile(reader);
    }

    string[] str = Split(file);
    Console.WriteLine(str.Length);

    int[] array = CharCount(str);
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"String {i}, symbols: {array[i]}");

    RemoveLastString(str);

    Console.Write("Enter string 1 (From): ");
    int s1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter string 2 (To): ");
    int s2 = Convert.ToInt32(Console.ReadLine());

    PrintFromTo(str, s1, s2);
    StringMax(str);

    Console.Write("Enter letter: ");
    char letter = Convert.ToChar(Console.ReadLine());

    SentenceOnLetter(str, letter);

    OutReverse(str);
}

catch (Exception e)
{
    Console.WriteLine($"An error occured - {e.Message}");
}

void PrintFile(StreamReader reader)
{
    Console.WriteLine(reader.ReadToEnd());
}

string[] Split(string file)
{
    string[] str = File.ReadAllLines(file);
    return str;
}

int[] CharCount(string[] str)
{
    int[] array = new int[str.Length];
    for (int i = 0; i < array.Length; i++)
        array[i] = str[i].Length;
    return array;
}

void RemoveLastString(string[] str)
{
    string[] s = new string[str.Length-1];
    for (int i = 0; i < s.Length; i++)
        s[i] = str[i];
    File.WriteAllLines("lsremove.txt", s); 
}

void PrintFromTo(string[] str, int s1, int s2)
{
    for (int i = s1; i <= s2; i++)
    {
        Console.WriteLine(str[i]);
    }
}

void StringMax(string[] str)
{
    Console.WriteLine(str.Select((x) => x.Length).Max());
}

void SentenceOnLetter(string[] str, char letter)
{
    for (int i = 0; i < str.Length; i++)
        if (str[i][0] == letter)
            Console.WriteLine(str[i]);
}

void OutReverse(string[] str)
{
    Array.Reverse(str);
    StreamWriter writer = new StreamWriter("reverseout.txt");
    foreach(string s in str)
    {
        writer.WriteLine(s);
    }
    writer.Close();
}