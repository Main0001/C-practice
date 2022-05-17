try
{
    Console.Write("Первое число = ");
    var inputNumber1 = double.Parse(Console.ReadLine());
    Console.Write("Второе число = ");
    var inputNumber2 = double.Parse(Console.ReadLine());
    Console.Write("Третье число = ");
    var inputNumber3 = double.Parse(Console.ReadLine());
    Console.Write("Четвертое число = ");
    var inputNumber4 = double.Parse(Console.ReadLine());
    Console.Write("Пятое число = ");
    var inputNumber5 = double.Parse(Console.ReadLine());

    Console.WriteLine("RESULTS:");
    Console.WriteLine(PowerA3(inputNumber1));
    Console.WriteLine(PowerA3(inputNumber2));
    Console.WriteLine(PowerA3(inputNumber3));
    Console.WriteLine(PowerA3(inputNumber4));
    Console.WriteLine(PowerA3(inputNumber5));
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}


double PowerA3 (double a)
{
    var b = Math.Pow(a, 3);
    return b;
}