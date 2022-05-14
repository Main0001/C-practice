try
{
    Counter counter = new Counter();
    var stop = true;
    while (stop)
    {
        Console.WriteLine("\nНажмите '1', чтобы вывести значение счетчика");
        Console.WriteLine("Нажмите '2', чтобы увеличить значение счетчика");
        Console.WriteLine("Нажмите '3', чтобы уменьшить значение счетчика");
        Console.WriteLine("Нажмите '0', чтобы завершить программу");
        var personStop = int.Parse(Console.ReadLine());

        if (personStop == 0)
        {
            stop = false;
        }
        else if (personStop == 1)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"result = {counter.Result}");
            Console.WriteLine("--------------------------------");
        }
        else if (personStop == 2)
        {
            Console.WriteLine("--------------------------------");
            counter.increase();
            Console.WriteLine("Счетчик увеличил свое значение");
            Console.WriteLine("--------------------------------");
        }
        else if (personStop == 3)
        {
            Console.WriteLine("--------------------------------");
            counter.low();
            Console.WriteLine("Счетчик уменьшил свое значение");
            Console.WriteLine("--------------------------------");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Counter
{
    public int value;
    public int min;
    public int max;
    public string Result { get { return value.ToString(); } }

    public Counter(int value = 0, int min = 0, int max = 10)
    {
        this.value = value;
        this.min = min;
        this.max = max;
    }

    public void low()
    {
        value -= 1;
        if (value < min) { value = max;}
    }
    public void increase()
    {
        value += 1;
        if (value > max) { value = min;}
    }


}