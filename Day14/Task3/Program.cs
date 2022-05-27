try
{
    Console.Write("Введите имя: ");
    string name = Console.ReadLine();

    MyInfo inf = new MyInfo();

    inf.Notify += inf.DisplayMessage;
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