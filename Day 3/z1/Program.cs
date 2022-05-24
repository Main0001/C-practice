A classA = new A(6, 17);
Console.WriteLine($"Average of a and b is = {classA.GetAvarege()}");
Console.WriteLine($"b^3+(1/2*a) = {classA.GetResultOfException()}");
class A
{
    public int a;
    public int b;

    public A(int a_, int b_)
    {
        this.a = a_; this.b = b_;
    }

    public double GetAvarege()
    {
        return a + b / 2;
    }

    public double GetResultOfException()
    {
        return Math.Pow(b, 3) + Math.Sqrt(a);
    }
}

