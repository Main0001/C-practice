try
{
    var s = new List<Bird>(){new Stork("Stork",5), new Crow("Crow",5), new Stork("Stork", 6), new Crow("Crow", 6), new Stork("Stork", 7), new Crow("Crow", 7) };

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
abstract class Bird
{
    public abstract string Breed { get; set; }
    public abstract void Calculate();

}
class Stork : Bird
{
    public override string Breed { get ; set; }
    private double wingspanL;
    public Stork(string breed, double wingspanL)
    {
        this.Breed = breed;
        this.wingspanL = wingspanL;
    }
    public override void Calculate()
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this.Breed, this.GetType());
        Console.WriteLine($"Wingspan = {wingspanL}");
        Console.WriteLine($"Result = {(double)(wingspanL * 1 / 2000)}");
    }
}
class Crow : Bird
{
    public override string Breed { get; set; }
    private double heightL;
    public Crow(string breed, double heightL)
    {
        this.Breed = breed;
        this.heightL = heightL;
    }
    public override void Calculate() // override - используется, чтобы переписать метод (метод Calculate() родительского класса)
    {
        Console.WriteLine("Calculating the {0} / Object type is: {1}", this.Breed, this.GetType());
        Console.WriteLine($"height = {heightL}");
        Console.WriteLine($"Result = {(double)(0.8 * heightL)}");
    }
}

//abstract class Crow : Bird // реализация потомка в качестве абстрактного класса (тогда не нужно переопределять абстрактные свойства родительского класса)
//{
//    private double heightL;
//    public Crow(string breed, double heightL)
//    {
//        this.heightL = heightL;
//    }
//    public override void Calculate() // override - используется, чтобы переписать метод (метод Calculate() родительского класса)
//    {
//        Console.WriteLine($"height = {heightL}");
//        Console.WriteLine($"Result = {(double)(0.8 * heightL)}");
//    }
//}