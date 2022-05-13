Console.WriteLine("Введите стороны треугольника: ");

try
{
    Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("b = ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("c = ");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a == b && a == c)
        Console.WriteLine("Треугольник является равносторонним");
    else
        Console.WriteLine("Треугольник не является равносторонним");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}