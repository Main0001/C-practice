using System;
using System.Threading;
using System.Threading.Tasks;

var number = 0;

while (true)
{
    try
    {
        Console.Write("Enter 4-digit number: ");
        number = int.Parse(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            throw new FormatException();
        }
        FirstTask(number);
        SecondTask(number);
        ThirdTask(number);
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine($"An error occured - {e.Message}");
    }
}

static string intParser(int num)
{
    int lastNumber = num % 10;
    int firstNumber = num / 1000;
    string SwapNumber = $"{lastNumber}{(num / 10) % 100}{firstNumber}";

    return SwapNumber;

}

void FirstTask(int num)
{
    Task SwapNum1 = Task.Run(() =>
    {
        Console.WriteLine($"Task 1 res: {intParser(num)}");

    });
    SwapNum1.Wait();
}

void SecondTask(int num)
{
    Task SwapNum2 = Task.Factory.StartNew(() =>
    {
        Console.WriteLine($"Task 2 res: {intParser(num)}");

    });
    SwapNum2.Wait();
}

void ThirdTask(int num)
{
    Thread.CurrentThread.Name = "Main_Thread";
    Task SwapNum3 = new Task(() =>
    {
        Console.WriteLine($"Task 3 res: {intParser(num)}");
    }
    );
    SwapNum3.Start();
    SwapNum3.Wait();
}
