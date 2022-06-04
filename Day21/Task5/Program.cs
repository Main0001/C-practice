List<int> list = new List<int>() { 34, 7, 87, 12 };

try
{
    Parallel.ForEach<int>(list, (x, state) =>
    {
        if (x * 10 > 200)
        {
            Console.WriteLine("Выполнение прервано");
            state.Break();
        }
        
        Console.WriteLine(x);

    });
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}