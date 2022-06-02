using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

int a = 5, b = 10, number;
Queue<int> intervalAB = new Queue<int>();
Queue<int> Alower = new Queue<int>();
Queue<int> Bhigher = new Queue<int>();

using (StreamReader sr = new StreamReader(@"file.txt", Encoding.UTF8))
{
    while (!sr.EndOfStream)
    {
        number = int.Parse(sr.ReadLine());
        if (number < a)
            Alower.Enqueue(number);
        else if (number > b)
            Bhigher.Enqueue(number);
        else
            intervalAB.Enqueue(number);
    }
}
Console.WriteLine(string.Join(" ", intervalAB));
Console.WriteLine(string.Join(" ", Alower));
Console.WriteLine(string.Join(" ", Bhigher));