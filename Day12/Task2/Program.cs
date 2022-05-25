try
{
    List<Quad> quads = new List<Quad>() {new Rectangle("Прямоугольник",5,4),
    new Rectangle("Прямоугольник",5,3), new Square("Квадрат", 4), new Square("Квадрат", 10)};

    int max = 0;
    foreach (Quad item in quads)
    {
        item.Print();
        if (item.Sqr > max)
            max = item.Sqr;
        Console.WriteLine();
    }

    Console.WriteLine($"Максимальная площадь: {max}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

abstract class Quad
{
    public abstract string Name { get; set; }
    public abstract int Sqr { get; set; }

    public abstract void Print();
}

class Rectangle : Quad
{
    int width;
    int length;
    public override int Sqr { get; set; }
    public override string Name { get; set; }

    public Rectangle(string name, int width, int length)
    {
        this.width = width;
        this.length = length;
        this.Name = name;
        Sqr = width * length;
    }

    public override void Print()
    {
        Console.WriteLine($"Название четырхугольника: {Name}, плошадь фигуры: {Sqr}");
    }
}

class Square : Quad
{
    int length;
    public override int Sqr { get; set; }
    public override string Name { get; set; }

    public Square(string name, int length)
    {
        this.Name = name;
        this.length = length;
        Sqr = (int)Math.Pow(length, 2);
    }

    public override void Print()
    {
        Console.WriteLine($"Название четырхугольника: {Name}, плошадь фигуры: {Sqr}");
    }
}