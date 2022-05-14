class A
{
    public int a;
    public int b;

    public A(int a_, int b_)
    {
        this.a = a_; this.b = b_;
    }

    public double MakeSomethinWrong()
    {
        return (double)((Math.Sin(b) + 4) / (2 * a));
    }

    public double MakeSomethinWrong2()
    {
        return (double)(Math.Pow(a + b, 2));
    }
}
class Temp
{
    static void Main(string[] args)
    {
        A classA = new A(5, 5);
        Console.WriteLine($"(Math.Sin(b) + 4) / (2 * a) = {classA.MakeSomethinWrong()}");
        Console.WriteLine($"(a + b)^2 = {classA.MakeSomethinWrong2()}");
    }
}
