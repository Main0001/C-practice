double area;
int radius;

try
{
    Console.WriteLine("Введите целочисленный неотрицательный радиус:");
    radius = int.Parse(Console.ReadLine());

    if (radius > 0)
    {
        area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine(area);
    }
    else
    {
        Console.WriteLine("Радиус не может быть отрицательным");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
