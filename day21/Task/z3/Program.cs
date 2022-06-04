try
{
    Console.Write("Введите двузначное число: ");
    var str = Console.ReadLine();
    int number = int.Parse(str);
    var lastNum = 0;
    var firstNum = 0;

    if (str.Length == 2)
    {
        Task task1 = new Task(() =>
        {
             lastNum = number % 10;
             firstNum = number / 10;
        });
        Task task2 = task1.ContinueWith(t => Console.WriteLine($"First number = {firstNum}\nLast number = {lastNum}"));
        task1.Start();
        task2.Wait();
    }
    else
    {
        Console.WriteLine("Введено не двузначное число!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}