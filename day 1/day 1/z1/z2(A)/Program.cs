int number;
int result = 0;

try
{
    Console.Write("Введите четырехзначное число: ");
    number = int.Parse(Console.ReadLine());

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }

    Console.WriteLine($"result = {result}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}