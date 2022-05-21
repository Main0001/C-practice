using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Znak> set = new SortedSet<Znak>(new ZnakComparer());

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter surname: ");
                string surname = Console.ReadLine();
                Console.Write("Enter Zodiac sign: ");
                string sign = Console.ReadLine();
                Console.WriteLine("Enter information about birthday: ");
                Console.Write("Enter day of birth: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Enter month of birth: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Enter year of birth: ");
                int year = int.Parse(Console.ReadLine());

                int[] bornDate = new int[] { day, month, year };
                set.Add(new Znak(name, surname, sign, bornDate));
            }

            while (true)
            {
                Console.WriteLine("Enter Zodiac sign (enter '0' to exit): ");
                string zodiac = Console.ReadLine();

                List<Znak> result = (from n in set where n.zodiac == zodiac select n).ToList<Znak>();
                if (result.Count != 0)
                {
                    foreach (var n in result)
                    {
                        Console.WriteLine(n.ToString());
                    }
                }
                else if (zodiac == "0")
                {
                    break;
                }
                else { Console.WriteLine($"No data found with sign '{zodiac}''!"); }

            }
        }
    }
    public struct Znak
    {
        public string zName;
        public string zSurname;
        public string zodiac;
        public int[] Birth;


        public Znak(string name, string surname, string zod, int[] date)
        {
            zName = name;
            zSurname = surname;
            zodiac = zod;
            Birth = new int[date.Length];
            Birth = date;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Surname: {1}, Zodiac sign: {2}, Date of birth: {3}.{4}.{5}",
                zName, zSurname, zodiac, Birth[0], Birth[1], Birth[2]);
        }

    }
    class ZnakComparer : IComparer<Znak>
    {
        public int Compare(Znak x, Znak y)
        {
            if (x.Birth[0] > y.Birth[0])
                return 1;
            if (x.Birth[0] < y.Birth[0])
                return -1;
            else
                return 0;
        }
    }
}