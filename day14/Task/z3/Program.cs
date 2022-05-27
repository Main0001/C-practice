try
{
    MyInfo myInfo = new MyInfo();
    myInfo.MyEvt += evt => Console.WriteLine(evt);

    myInfo.Name = "Max";
    myInfo.Name = "Art";
    myInfo.Name = "Vlad";

    Console.ReadLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class MyInfo
{
    public delegate void MyEventHandler(string message);
    public event MyEventHandler MyEvt = delegate { };
    string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            if (name != null)
            {
                MyEvt($"Имя изменено на {name}");
            }
        }
    }
}
