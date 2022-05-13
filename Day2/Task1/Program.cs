Console.Write("Введите x: ");

try
{
    double x = Convert.ToInt32(Console.ReadLine());
    double y = 0;

    if (x > 6.7)
        y = 4 - Math.Pow(Math.E, 4 * x);
    else
        y = Math.Log10(3.5 + x);

    Console.WriteLine("y = " + y);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}