using System;
using System.IO;
using System.Linq;

var file1 = @"f1.txt";
var file2 = @"f2.txt";

if (!File.Exists(file1))
{
    File.Create(file1);
}
if (!File.Exists(file2))
{
    File.Create(file2);
}

var StringsFile1 = File.ReadAllLines(file1);
var StringsFile2 = File.ReadAllLines(file2);

if (StringsFile1.Count() != StringsFile2.Count())
{
    Console.WriteLine("Files are not the same by their strings length!");
}
else
{
    Console.WriteLine("Files are the same by their string length!");
    var index = FindFirstIndex(StringsFile1, StringsFile2);

    if (index == -1)
    {
        Console.WriteLine("Files are the same");
    }
    else
    {
        Console.WriteLine($"Files are not the same in string {index}!");
    }
}

int FindFirstIndex(string[] StringsFile1, string[] StringsFile2)
{
    var index = -1;
    for (int i = 0; i < StringsFile1.Count(); i++)
    {
        if (!StringsFile1[i].Equals(StringsFile2[i]))
        {
            return i + 1;
        }
    }
    return index;
}