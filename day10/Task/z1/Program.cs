try
{
    TestClass task1 = new TestClass('F');

    Ix taskX = task1;
    Iy taskY = task1;
    Iz taskZ = task1;

    Console.WriteLine("----------------------------------------------");
    var x = (Ix)task1;
    x.IxF0('F');
    Console.WriteLine("----------------------------------------------");
    taskX.IxF0('A');
    taskX.IxF1();
    Console.WriteLine("----------------------------------------------");
    taskY.F0('A');
    taskY.F1();
    Console.WriteLine("----------------------------------------------");
    taskZ.F0('A');
    taskZ.F1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class TestClass : Ix, Iy, Iz
{
    public char w;

    public TestClass(char w)
    {
        this.w = w;
    }

    public void IxF0(char w)
    {
        var second = w.ToString();
        var third = second.ToLower();
        Console.WriteLine(third);
    }
    public void IxF1()
    {
        var second = w.ToString();
        var third = second.ToLower();
        Console.WriteLine(third);
    }
    public void F0(char w)
    {
        if (char.IsLetter(w))
        {
            Console.WriteLine("*");
        }
        else
        {
            Console.WriteLine("не буква");
        }
        
    }
    public void F1()
    {
        if (char.IsLetter(w))
        {
            Console.WriteLine("*");
        }
        else
        {
            Console.WriteLine("не буква");
        }
    }
    void Iz.F0(char w)
    {
        if (char.IsLetter(w))
        {
            Console.WriteLine("5");
        }
        else
        {
            Console.WriteLine("не буква");
        }
    }
    void Iz.F1()
    {
        if (char.IsLetter(w))
        {
            Console.WriteLine("5");
        }
        else
        {
            Console.WriteLine("не буква");
        }
    }
}
interface Ix
{
    void IxF0(char w);
    void IxF1();
}
interface Iy
{
    void F0(char w);
    void F1();
}
interface Iz
{
    void F0(char w);
    void F1();
}