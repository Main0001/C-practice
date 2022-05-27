namespace ConsoleApplication28
{
    class Program
    {
        class MyInfo
        {
            public delegate void MyEventHandler(string message); //сигнатура обработчика, который можно привязать к событию.
            public event MyEventHandler NameEvent = delegate { }; //собственно событие.
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
                    NameEvent($"Установлено значение имени: {name}");
                }
            }
        }

        static void Main(string[] args)
        {
            MyInfo obj = new MyInfo();
            obj.NameEvent += x => Console.WriteLine(x);//тут подписались
            obj.Name = "Леша";//тут меняем свойство и событие генерируется

            obj.Name = "Никита";//тут меняем свойство и событие генерируется

            obj.Name = "Артём";//тут меняем свойство и событие генерируется
            Console.Read();
        }
    }
}