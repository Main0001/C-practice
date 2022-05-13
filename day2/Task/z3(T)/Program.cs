try
{
    Console.Write("Введите k = ");
    var k = int.Parse(Console.ReadLine());
    Console.Write("Введите n = ");
    var n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(k);
    } 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}