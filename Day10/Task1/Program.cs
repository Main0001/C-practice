try
{
    Console.WriteLine("Введите w: ");
    int w = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите x");
    int f = Convert.ToInt32(Console.ReadLine());

    TestClass test = new TestClass(w);
    Ix x = test;
    Iy y = test;
    Iz z = test;

    x.IxF0(f);
    x.IxF1();

    y.F0(f);
    y.F1();

    z.F0(f);
    z.F1();
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

interface Ix
{
    void IxF0(int w);
    void IxF1();
}
interface Iy
{
    void F0(int w);
    void F1();
}
interface Iz
{
    void F0(int w);
    void F1();
}

public class TestClass : Ix, Iy, Iz
{
    private int _w;

    public TestClass(int w)
    {
        _w = w;
    }

    public void IxF0(int w)
    {
        Console.WriteLine(7 * w);
    }

    public void IxF1()
    {
        Console.WriteLine(7 * _w);
    }

    public void F0(int w)
    {
        Console.WriteLine(w * 8);
    }

    public void F1()
    {
        Console.WriteLine(_w * 8);
    }

    void Iz.F0(int w)
    {
        Console.WriteLine(6 + w);
    }

    void Iz.F1()
    {
        Console.WriteLine(6 +_w);
    }
}