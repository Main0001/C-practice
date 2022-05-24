double i = 0.1;
Console.WriteLine("Enter number(which case of running you expect more\n\r1.For cycle\n\r2.While cycle\n\r3.Do while cycle");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        GetForCycle();
        break;
    case 2:
        GetWhileCycle();
        break;
    case 3:
        GetDoWhileCycle();
        break;
}
void GetForCycle()
{
    double cost = double.Parse(Console.ReadLine());
    for (; i < 1.0; i += 0.1)
        Console.WriteLine($"Price for {Math.Round(i, 1)}kg sweets is: {Math.Round(cost * i, 2)}");
}
void GetWhileCycle()
{
    double cost = double.Parse(Console.ReadLine());
    while(i < 1.0)
    {
        Console.WriteLine($"Price for {Math.Round(i, 1)}kg sweets is: {Math.Round(cost * i, 2)}");
        i += 0.1;
    }
}
void GetDoWhileCycle()
{
    double cost = double.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine($"Price for {Math.Round(i, 1)}kg sweets is: {Math.Round(cost * i, 2)}");
        i += 0.1;
    }
    while (i < 1.0);
}