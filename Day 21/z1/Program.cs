try
{
    var secNum = 0;
    Console.Write("Введите трехзначное число: ");
    string str = Console.ReadLine();

    Task task = new Task(() =>
    {
        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
        Console.WriteLine();
        for (int i = 0; i < str.Length; i++) Console.Write(str[i]);
    });
    task.Start();
    task.Wait();

    var task2 = Task.Factory.StartNew(() =>
    {
        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
        Console.WriteLine();
        for (int i = 0; i < str.Length; i++) Console.Write(str[i]);
    });
    task2.Wait();

    Task task3 = Task.Run(() =>
    {
        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
        Console.WriteLine();
        for (int i = 0; i < str.Length; i++) Console.Write(str[i]);
    });
    task3.Wait();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
