try
{
    var s = new List<Bird>(){new Bird("Unidentified Bird"),
            new Stork("Stork",5), new Crow("Crow",5),
            new Stork("Stork",6), new Crow("Crow",6),
            new Stork("Stork",7), new Crow("Crow",7)};

    foreach (Bird p in s)
    {
        p.Calculate();
        Console.WriteLine();
    }
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Bird
{
    private string _Breed { get; set; }
    public Bird(string breed)
    {
        this._Breed = breed;
    }
    public virtual void Calculate() //virtual - можем переписывать этот метод (метод Calculate())
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this._Breed, this.GetType());

    }
}
class Stork : Bird
{
    private double wingspanL;
    public Stork(string breed, double wingspanL) : base(breed)
    {
        this.wingspanL = wingspanL;
    }
    public override void Calculate()
    {
        base.Calculate(); //base - вызывает этот метод в родительском классе (метод Calculate())
        Console.WriteLine($"Wingspan = {wingspanL}");
        Console.WriteLine($"Result = {(double)(wingspanL * 1 / 2000)}");
    }
}
class Crow : Bird
{
    private double heightL;
    public Crow(string breed, double heightL) : base(breed)
    {
        this.heightL = heightL;
    }
    public override void Calculate() // override - используется, чтобы переписать метод (метод Calculate() родительского класса)
    {
        base.Calculate();
        Console.WriteLine($"height = {heightL}");
        Console.WriteLine($"Result = {(double)(0.8 * heightL)}");
    }
}