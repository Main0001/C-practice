using System;

namespace ConsoleApplication28
{
    class Program
    {
        class MyInfo
        {
            public delegate void MyEventHandler(string message);
            public event MyEventHandler ChangeEvent = delegate { };
            string name = "Aleksey";
            public string SetValue
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                    ChangeEvent($"Name has been changed: {name}");
                }
            }
        }

        static void Main(string[] args)
        {
            MyInfo obj = new MyInfo();
            obj.ChangeEvent += x => Console.WriteLine(x);
            obj.SetValue = "Mike";

            obj.SetValue = "Jake";

            obj.SetValue = "Finn";
        }
    }
}