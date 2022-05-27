class TestStrAndDelegate
{
    public void StrPrint()
    {
        Console.WriteLine("Тест делегата в качестве параметра");
    }
    public void StrPrintx2()
    {
        Console.WriteLine("Тест делегата в качестве параметра");
    }
    public void DelegatePrint(Message msg) //делегат в качестве параметра
    {
        msg(); //выполняем делегат (выполняем методы, которые мы занесли в делегат)
    }
}
class MyEvent
{
    public event MyEventHandler activate; //public event имя_делегата имя_объекта
    public void fire() //запуск события
    {
        if(activate != null)
        {
            activate();
        }
    }
}
class X
{
    public void Xhandler()
    {
        Console.WriteLine("Res = X");
    }
}
class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Res = Y");
    }
}
class EventDemo
{
    static void Handler()
    {
        Console.WriteLine("Res = Event");
    }
    public static void Main()
    {
        try
        {
            MyEvent evt = new MyEvent();
            X xObj = new X();
            Y yObj = new Y();

            evt.activate += new MyEventHandler(xObj.Xhandler); //в событие передаем делгат MyEventHandler, в скобках которого указываем метод определенного объекта
            evt.activate += new MyEventHandler(yObj.Yhandler);
            evt.activate += new MyEventHandler(Handler);
            evt.fire(); //активируем событие, тем самым запуская методы объектов, переданных в него (в событие)
            Console.WriteLine();

            TestStrAndDelegate testStr = new TestStrAndDelegate();
            Message msg = testStr.StrPrint;
            msg += testStr.StrPrintx2;

            testStr.DelegatePrint(msg);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

delegate void MyEventHandler();
delegate void Message();