using System;

class Program
{
    static void Main(string[] args)
    {
        Car auto = new Car(4, "Porsche", new GasMove());
        auto.Move();
        auto.Movable = new ElectricMove();
        auto.Move();
    }
}
interface IMovable
{
    void Move();
}

class GasMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Uses gasoline to move");
    }
}

class ElectricMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Uses electricity to move");
    }
}
class Car
{
    protected int seats;
    protected string model;

    public Car(int amount, string model, IMovable move)
    {
        this.seats = amount;
        this.model = model;
        Movable = move;
    }
    public IMovable Movable { private get; set; }
    public void Move()
    {
        Movable.Move();
    }
}