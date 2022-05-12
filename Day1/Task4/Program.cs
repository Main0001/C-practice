int result = 0;

Console.Write("Введите ширину комнаты: ");
int roomWidth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту комнаты: ");
int roomHeight = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину двери: ");
int doorWidth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту двери: ");
int doorHeight = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину окна: ");
int windowWidth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту окна: ");
int windowHeight = Convert.ToInt32(Console.ReadLine());

try
{
    result = roomWidth * roomHeight - (doorWidth * doorHeight + windowWidth * windowHeight);
    if (result < 0)
        Console.WriteLine("Неправильные данные");
    else Console.WriteLine($"Вам понадобится {result} м обоев");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}