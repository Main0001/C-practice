static void DisplayValues(Animal p)
{
    Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
        p.Name, p.Age, p.BirthDate);
    Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
}

Animal p1 = new Animal();
p1.Age = 42;
p1.BirthDate = Convert.ToDateTime("1990-01-01");
p1.Name = "Betsy";
p1.IdInfo = new IdInfo(111);

Animal p2 = p1.ShallowCopy();
Animal p3 = p1.DeepCopy();

Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   p1 instance values: ");
DisplayValues(p1);
Console.WriteLine("   p2 instance values:");
DisplayValues(p2);
Console.WriteLine("   p3 instance values:");
DisplayValues(p3);

p1.Age = 32;
p1.BirthDate = Convert.ToDateTime("1900-01-01");
p1.Name = "Frank";
p1.IdInfo.IdNumber = 222;
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