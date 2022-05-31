using System;
using System.IO;
using System.Linq;
using System.Text;

int[] fmass = new int[30];
int PositiveCount = 0;
Random rand = new Random();

using (FileStream file = new FileStream(@"file.txt", FileMode.OpenOrCreate))
{
    using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
    {
        for (int i = 0; i < fmass.Length; i++)
        {
            writer.WriteLine(rand.Next(-10, 10));
        }
    }
}
using (StreamReader reader = new StreamReader(@"file.txt"))
{
    for (int i = 0; i < fmass.Length; i++)
    {
        fmass[i] = int.Parse(reader.ReadLine());
    }
}
int min = fmass.Min();

for (int e = 0; e < fmass.Length; e++)
{
    if (fmass[e] >= 0)
    {
        PositiveCount++;
    }
}
Console.WriteLine($"Minimum:{min}\nAmount of positive numbers: {PositiveCount}");