try
{
    MyList<int> list = new MyList<int>();

    list.Add(1);
    list.Add(2);

    int[] arr = list.GetArray();

    Console.WriteLine($"Первый элемент списка: {list[0]}");
    Console.WriteLine($"Общее количество элементов: {list.Capacity}");

    foreach (int i in arr)
    {
        Console.WriteLine(i);
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class MyList<T>
{
    public List<T> list = new List<T>();

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

public static class GetArr
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        return list.list.ToArray();
    }
}
