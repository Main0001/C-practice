try
{
    List<Quad> quads = new List<Quad>() { new Quad("Параллелограмм"), new Quad("Четырёхугольник"), new Rectangle("Прямоугольник",5,4),
    new Rectangle("Прямоугольник",5,3), new Square("Квадрат", 4), new Square("Квадрат", 10)};

    foreach (Quad item in quads)
    {
        item.Print();
        Console.WriteLine();
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Quad
{
    public string name;

    public Quad(string name) => this.name = name;

    public virtual void Print()
    {
        Console.WriteLine($"Название четырёхугольника: {name}");
    }
}

class Rectangle : Quad
{
    int width;
    int length;

    public Rectangle(string name, int width, int length) : base(name)
    {
        this.width = width;
        this.length = length;
    }

    public override void Print()
    {
        Console.WriteLine($"Название четырхугольника: {name}, плошадь фигуры: {width * length}");
    }
}

class Square : Quad
{
    int length;

    public Square(string name, int length) : base(name) => this.length = length;

    public override void Print()
    {
        Console.WriteLine($"Название четырхугольника: {name}, плошадь фигуры: {Math.Pow(length, 2)}");
    }
}