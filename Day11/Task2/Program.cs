A aObj = new(5, 3);
aObj.Print();
B bObj = new(0, 3, 4);
bObj.Print();
bObj.C2 = 3;
Console.WriteLine($"Результат: {bObj.C2}");

class A
{
    public double a;
    public double b;

    public A(double a, double b) { this.a = a; this.b = b; }

    public void Print() => Console.WriteLine($"a: {a} b: {b}");
}

class B : A
{
    public double d;
    public double result;

    public double C2
    {
        get { return result; }
        set
        {
            switch (d)
            {
                case 0: result = a + b + value; break;
                case 1: result = a - b - value; break;
                case 2: result = a * b * value; break;
                case 3: result = a / b / value; break;
                case 4: result = a % b % value; break;
            }
        }
    }

    public B(double d, double a, double b) : base(a, b)
    {
        this.d = d;
    }

    public new void Print() => Console.WriteLine($"a: {a} b: {b} d: {d}");
}