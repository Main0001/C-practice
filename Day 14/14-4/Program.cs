try
{
    Console.Write("Введите имя: ");
    string name = Console.ReadLine();

    MyInfo inf = new MyInfo();
    X xObj = new X();
    Y yObj = new Y();

    inf.Notify += inf.DisplayMessage;
    inf.Notify += xObj.XHandler;
    inf.Notify += yObj.YHandler;
    inf.ChangeName(name);

    Console.WriteLine();

    inf.Notify -= yObj.YHandler;
    inf.ChangeName(name);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

delegate void Info(string message);
class MyInfo
{
    public string name = "Tom";
    public event Info? Notify;

    public void ChangeName(string name)
    {
        this.name = name;
        Notify?.Invoke($"Имя было изменено на {name}");
    }

    public void DisplayMessage(string message) => Console.WriteLine(message);
}

class X
{
    public void XHandler(string name) => Console.WriteLine($"{name} - хорошее имя");
}

class Y
{
    public void YHandler(string name) => Console.WriteLine($"{name} - прекрасное имя");
}