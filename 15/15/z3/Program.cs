using System;
using System.Collections.Generic;

try
{
    MyList<int> list = new MyList<int>();

    list.Add(5);
    list.Add(9);
    list.Add(18);

    int[] array = list.GetArr();

    Console.WriteLine($"First dictionary element: {list[0]}");
    Console.WriteLine($"Total amount of elements: {list.TotalAmount}");

    foreach (int i in array)
    {
        Console.WriteLine(i);
    }
}

catch (Exception e)
{
    Console.WriteLine($"An error occured! {e.Message}");
}

public class MyList<T>
{
    public List<T> list = new List<T>();

    public T this[int i]
    {
        get { return list[i]; }
    }

    public int TotalAmount { get { return list.Count; } }

    public void Add(T a)
    {
        list.Add(a);
    }
}

public static class GetArray
{
    public static T[] GetArr<T>(this MyList<T> list)
    {
        return list.list.ToArray();
    }
}
