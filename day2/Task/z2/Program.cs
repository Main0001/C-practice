try
{
    Console.Write("Введите первое число = ");
    var firstNumber = double.Parse(Console.ReadLine());
    Console.Write("Введите второе число = ");
    var secondNumber = double.Parse(Console.ReadLine());

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первое больше");
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine("Второе больше");
    }
    else
    {
        Console.WriteLine("Числа равны"); 
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}