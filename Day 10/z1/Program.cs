
TestClass testClass = new TestClass();
TestClass testClass1 = new TestClass(5);

Console.WriteLine($"IxF0 - "); testClass.IxF0(5);
Console.WriteLine($"IxF1 -"); testClass1.IxF1();

Console.WriteLine("BEBEBE");
testClass.F0(5);
testClass1.F1();



Console.WriteLine("BEBEBEBE");
(testClass as Iy).F0(7);
(testClass1 as Iz).F1();


Console.WriteLine("==========Ix==========");
Ix ix = testClass1;
ix.IxF0(5);
ix.IxF1();

Console.WriteLine("==========Iy==========");
Iy iy = testClass1;
iy.F0(5);
iy.F1();

Console.WriteLine("==========Iz==========");
Iz iz = testClass1;
iz.F0(5);
iz.F1();


interface Ix
{
    void IxF0(double w);
    void IxF1();
}
interface Iy
{
    void F0(double w);
    void F1();
}
interface Iz
{
    void F0(double w);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    double w;
    public TestClass()

    {
        w = 125;

    }
    public TestClass(double W)
    {
        w = W;
    }
    public void IxF0(double w)
    {
        Console.WriteLine(Math.Log(w));
    }

    public void IxF1()
    {
        Console.WriteLine(Math.Log(w));
    }

    public void F0(double w)
    {
        Console.WriteLine(2 / w);
    }

    public void F1()
    {
        Console.WriteLine(2 / w);
    }

    void Iz.F0(double w)
    {
        Console.WriteLine(w + 2);
    }

    void Iz.F1()
    {
        Console.WriteLine(w + 2);
    }
}
