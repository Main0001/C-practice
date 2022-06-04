try
{
    var secNum = 0;
    Console.Write("Введмте четырехзначное число: ");
    var str = Console.ReadLine();

    var number = int.Parse(str);
    Task task = new Task(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            secNum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Result (v1) = {secNum}");
    });
    task.Start();
    task.Wait();

    var task2 = Task.Factory.StartNew(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            secNum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Result (v2) = {secNum}");
    });
    task2.Wait();

    Task task3 = Task.Run(() =>
    {
        for (int i = 0; i < str.Length; i++)
        {
            secNum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Result (v3) = {secNum}");
    });
    task3.Wait();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

