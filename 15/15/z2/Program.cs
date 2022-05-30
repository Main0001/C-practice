using System;
using System.Collections.Generic;

try
{
    MyDictionary<int, string> dict = new MyDictionary<int, string>();

    dict.Add(0, "10");
    dict.Add(1, "15");
    dict.Add(2, "20");

    Console.WriteLine($"First dictionary element: {dict[0]}");
    Console.WriteLine($"Total amount of elements: {dict.TotalAmount}");
}

catch (Exception e)
{
    Console.WriteLine($"An error occured! {e.Message}");
}

class MyDictionary<TKey, TValue>
{
    Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

    public TValue this[TKey key]
    {
        get { return dict[key]; }
    }

    public int TotalAmount { get { return dict.Count; } }

    public void Add(TKey key, TValue a)
    {
        dict.Add(key, a);
    }
}