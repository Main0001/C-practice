using System;
using System.IO;

string folder = @"New_Folder";

try
{
    if (Directory.Exists(folder))
    {
        Console.WriteLine("Folder already exists!");
        return;
    }
    DirectoryInfo direct = Directory.CreateDirectory(folder);
    Console.WriteLine("Folder created.");
}
catch (Exception e)
{
    Console.WriteLine($"An error occured! {e}");
}