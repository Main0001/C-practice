using System;

TestClass testClass = new TestClass();
TestClass testClass1 = new TestClass(2);

Console.WriteLine($"IxF0 - "); testClass.IxF0(2);
Console.WriteLine($"IxF1 - "); testClass1.IxF1();

Console.WriteLine("неявная неоднозначная реализация: ");
testClass.F0(2);
testClass1.F1();

Console.WriteLine("Явное приведение к типу интерфейса: ");
(testClass as Iy).F0(3);
(testClass1 as Iz).F1();

Console.WriteLine("Ix --->");
Ix ix = testClass1;
ix.IxF0(2);
ix.IxF1();

Console.WriteLine("Iy --->");
Iy iy = testClass1;
iy.F0(2);
iy.F1();

Console.WriteLine("Iz --->");
Iz iz = testClass1;
iz.F0(2);
iz.F1();


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

class TestClass : Ix, Iy, Iz
{
    int w;
    public TestClass()

    {
        w = 63;

    }
    public TestClass(int W)
    {
        w = W;
    }
    public void IxF0(int w)
    {
        Console.WriteLine(w + 5);
    }

    public void IxF1()
    {
        Console.WriteLine(w + 5);
    }

    public void F0(int w)
    {
        Console.WriteLine(Math.Pow(w, 3));
    }

    public void F1()
    {
        Console.WriteLine(Math.Pow(w, 3));
    }

    void Iz.F0(int w)
    {
        Console.WriteLine(7 * w - 2);
    }

    void Iz.F1()
    {
        Console.WriteLine(7 * w - 2);
    }
}

