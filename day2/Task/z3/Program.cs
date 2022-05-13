try
{
    Console.Write("Введите оценку = ");
    var mark = int.Parse(Console.ReadLine());
    if (mark <= 100 && mark >= 90)
    {
        Console.WriteLine("Отлично");
    }
    else if (mark <= 89 && mark >= 70)
    {
        Console.WriteLine("Хорошо");
    }
    else if (mark <= 69 && mark >= 50)
    {
        Console.WriteLine("Удовлетворительно");
    }
    else if (mark <= 50)
    {
        Console.WriteLine("Неудовлетворительно");
    }
    else
    {
        Console.WriteLine("Error");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
