try
{
    MyList<int> list = new MyList<int>();

    list.Add(1);
    list.Add(2);

    Console.WriteLine($"Первый элемент списка: {list[0]}");
    Console.WriteLine($"Общее количество элементов: {list.Capacity}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class MyList<T> 
{ 
    List<T> list = new List<T>();

    public T this[int i]
    {
        get { return list[i]; }
    }

    public int Capacity { get { return list.Count; } }

    public void Add(T value)
    {
        list.Add(value);
    }
}