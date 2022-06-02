using System;
using System.Collections.Generic;

namespace z3
{
    public class Plant
    {
        public string? Name = null;
        public string? Variety = null;
        public string? Reproduction = null;
        public IdInfo? IdInfo = null;

        public Plant ShallowCopy()
        {
            return (Plant)this.MemberwiseClone();
        }

        public Plant DeepCopy()
        {
            Plant clone = (Plant)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.ID);
            clone.Name = Name;
            return clone;
        }
    }

    public class IdInfo
    {
        public int ID;

        public IdInfo(int identifier)
        {
            this.ID = identifier;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plant p1 = new Plant();
            p1.Name = "Ulva lactuca";
            p1.Variety = "Seaweed";
            p1.Reproduction = "Vegetative";
            p1.IdInfo = new IdInfo(1);

            Plant p2 = p1.ShallowCopy();
            Plant p3 = p1.DeepCopy();

            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            p1.Name = "Polytrichum commune";
            p1.Variety = "Moss";
            p1.Reproduction = "disputes";
            p1.IdInfo.ID = 2;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            var plants = new Dictionary<int, Plant>();
            plants[p1.IdInfo.ID] = p1;
            plants[p2.IdInfo.ID] = p2;
            plants[p3.IdInfo.ID] = p3;
        }

        public static void DisplayValues(Plant p)
        {
            Console.WriteLine($"      Plant name: {p.Name}\nVariety: {p.Variety}, Reproduction: {p.Reproduction}");
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.ID);
        }
    }
}