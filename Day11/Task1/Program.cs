Product prod = new Product(15, 40);
prod.Print();

try
{
    Console.Write("Введите название фломастера: ");
    string name = Console.ReadLine();

    Console.Write("Введите сорт фломастера: ");
    int variety = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество фломастеров: ");
    int quantity = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите цену фломастера: ");
    double price = Convert.ToDouble(Console.ReadLine());

    FeltPen fP = new FeltPen(name, variety, quantity, price);

    fP.ChangePrice();

    fP.Print();
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Product
{
    internal int Quantity { get; set; }
    internal double Price { get; set; }

    public Product(int quantity, double price)
    {
        this.Quantity = quantity;
        this.Price = price;
    }

    public void Print()
    {
        Console.WriteLine($"Количество товара: {Quantity}, стоимость товара: {Price}");
    }
}

class FeltPen : Product
{
    private string Name { get; set; }
    private int Variety { get; set; }

    public FeltPen(string name, int variety, int quantity, double price) : base(quantity, price)
    {
        this.Name = name;
        this.Variety = variety;
    }

    internal void ChangePrice()
    {
        this.Price *= 1 / Math.Sqrt(this.Variety);
    }

    public new void Print() => Console.WriteLine($"Название фломастера: {Name}, сорт фломастера: {Variety}, цена фломастера: {Price}, количество фломастеров: {Quantity}");
}