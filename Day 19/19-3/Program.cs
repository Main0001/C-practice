using System;

namespace RefactoringGuru.DesignPatterns.Prototype.Conceptual
{
    public class Animal
    {
        public int? Age = null;
        public DateTime? BirthDate = null;
        public string? Name = null;
        public IdInfo? IdInfo = null;

        public Animal ShallowCopy()
        {
            return (Animal)this.MemberwiseClone();
        }

        public Animal DeepCopy()
        {
            Animal clone = (Animal)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal p1 = new Animal();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Выполнить поверхностное копирование p1 и присвоить её p2.
            Animal p2 = p1.ShallowCopy();
            // Сделать глубокую копию p1 и присвоить её p3.
            Animal p3 = p1.DeepCopy();

            // Вывести значения p1, p2 и p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Изменить значение свойств p1 и отобразить значения p1, p2 и p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            var animals = new Dictionary<int, Animal>();
            animals[p1.IdInfo.IdNumber] = p1;
            animals[p2.IdInfo.IdNumber] = p2;
            animals[p3.IdInfo.IdNumber] = p3;
        }

        public static void DisplayValues(Animal p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}