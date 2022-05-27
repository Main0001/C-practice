using System;

try
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();

    MyInfo inf = new MyInfo();
    A objA = new A();
    B objB = new B();

    inf.Detect += inf.Display;
    inf.Detect += objA.ObserverA;
    inf.Detect += objB.ObserverB;
    inf.NameChange(name);

    Console.WriteLine("Deleted observer result: ");

    inf.Detect -= objB.ObserverB;
    inf.NameChange(name);
}

catch (Exception e)
{
    Console.WriteLine($"An error occured! {e.Message}");
}

delegate void Name(string message);
class MyInfo
{
    public string name = "Aleksey";
    public event Name? Detect;

    public void NameChange(string name)
    {
        this.name = name;
        Detect?.Invoke($"Name has been changed! Current name: {name}");
    }

    public void Display(string message) => Console.WriteLine(message);
}

class A
{
    public void ObserverA(string name) => Console.WriteLine($"{name}: observe A");
}

class B
{
    public void ObserverB(string name) => Console.WriteLine($"{name}: observe B");
}