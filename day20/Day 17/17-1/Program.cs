using System.Text;

int[] mass = new int[25];
int countNeqative = 0;
Random rnd = new Random();

using (FileStream file = new FileStream(@"input.txt", FileMode.OpenOrCreate))
{
    using (StreamWriter _sw = new StreamWriter(file, Encoding.UTF8))
    {
        for (int i = 0; i < mass.Length; i++)
        {
            _sw.WriteLine(rnd.Next(-100, 100));
        }
    }
}
using (StreamReader _sr = new StreamReader(@"input.txt"))
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = int.Parse(_sr.ReadLine());
    }
}
int max = mass.Max();

for (int e = 0; e < mass.Length; e++)
{
    if (mass[e] <= 0)
    {
        countNeqative++;
    }
}
Console.WriteLine($"Максимум:{max}\nКоличество отрицательных цифр:{countNeqative}");