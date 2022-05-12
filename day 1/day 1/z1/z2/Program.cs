int number;
int firstNum;
int lastNum;

try
{
    Console.WriteLine("Введите двузначное число");
    number = int.Parse(Console.ReadLine());

    firstNum = number / 10;
    lastNum = number % 10;

    Console.WriteLine($"Первая цифра {firstNum} и последняя цифра {lastNum}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}
