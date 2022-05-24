try
{
    A a = new A(10, 20);
    B b = new B(0, 10, 2); // new B (a, b, d)
    Console.WriteLine($"Result = {b.c2}"); ;
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class A
{
    protected int a;
    protected int b;
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public A()
    {
        this.a = default(int);
        this.b = default(int);
    }
}

class B : A
{
    private int d;
    public B(int a, int b, int d)
        : base(a, b)
    {
        this.d = d;
    }
    public B(int d)
    {
        this.d = d;
    }
    public int c2
    {
        get
        {
            var sum = 0;
            do
            {
                sum += b + d;
                a++;
            } while (a < 10);
            return sum;
        }
    }
}