using System;
using System.Collections.Generic;

try
{
    MyList<int> list = new MyList<int>();

    list.Add(5);
    list.Add(9);
    list.Add(18);

    Console.WriteLine($"First list element: {list[0]}");
    Console.WriteLine($"Total amount of elements: {list.TotalElements}");
}

catch (Exception e)
{
    Console.WriteLine($"An error occured! {e.Message}");
}

class MyList<T>
{
    List<T> list = new List<T>();

    public T this[int i]
    {
        get { return list[i]; }
    }

    public int TotalElements { get { return list.Count; } }

    public void Add(T a)
    {
        list.Add(a);
    }
}