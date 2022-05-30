try
{
    MyDictionary<int, string> dict = new MyDictionary<int, string>();

    dict.Add(0, "1");
    dict.Add(1, "0");

    Console.WriteLine($"Первый элемент словаря: {dict[0]}");
    Console.WriteLine($"Общее количество элементов: {dict.Capacity}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class MyDictionary<TKey, TValue>
{
    Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

    public TValue this[TKey key]
    {
        get { return dict[key]; }
    }

    public int Capacity { get { return dict.Count; } }

    public void Add(TKey key, TValue value)
    {
        dict.Add(key, value);
    }
}