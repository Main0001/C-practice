try
{
    Console.WriteLine("Введите A:");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите B:");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите C:");
    int C = int.Parse(Console.ReadLine());

    int D = B * B - 4 * A * C;
    if (D >= 0)
        Console.WriteLine("Вещественные корни: D=" + D);
    else
        Console.WriteLine("Комплексные корни: D=" + D);
    Console.ReadKey(true);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}