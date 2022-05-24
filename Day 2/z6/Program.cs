Console.WriteLine("Не бейте пожалуйста я не хочу мучаться и делать отдельные методы для каждлого цикла");
int price = int.Parse(Console.ReadLine());
int i = 10;
int j = 10;
int z = 10;

Console.WriteLine("While cycle");
    while (i <= 200)
    {
        Console.WriteLine($"Price for {i} count products is {i * price}");
        i += 10;
    }
Console.WriteLine("Do while cycle");
    do
    {
        Console.WriteLine($"Price for {j} count products is {j * price}");
        j += 10;
    }
    while (j <= 200);

Console.WriteLine("For cycle");
    for( ; z <= 200; z += 10)
    {
        Console.WriteLine($"Price for {z} count products is {z * price}");
    }

