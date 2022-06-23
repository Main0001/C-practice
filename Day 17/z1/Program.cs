using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Сколько цифр должно быть в исходном файле (f)?");
            int n = int.Parse(Console.ReadLine());
            int r;

            File.WriteAllText("D:\\f.txt", "");
            File.WriteAllText("D:\\g.txt", "");
            for (int i = 0; i < n; i++)
            {
                r = rand.Next(0, 100);
                File.AppendAllText("D:\\f.txt", r + " ");
            }

            FileStream f = new FileStream("D:\\f.txt", FileMode.Open
            , FileAccess.Read);
            FileStream g = new FileStream("D:\\g.txt", FileMode.Open
            , FileAccess.Write);
            StreamReader rf = new StreamReader(f, Encoding.UTF8);
            StreamWriter wg = new StreamWriter(g, Encoding.UTF8);

            string str = File.ReadAllText("D:\\f.txt");
            int[] arr = str
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(m => int.Parse(m))
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 7 != 0)
                {
                    string z = arr[i] + " ";
                    wg.Write(z);
                }
            }

            wg.Close();
        }
    }




