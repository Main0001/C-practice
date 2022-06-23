try
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    char l1 = number[0];
    char l2 = number[1];

    var task1 = Task.Run(() =>
    {
        Console.WriteLine("EZ");
    });

    Task task2 = task1.ContinueWith(t => Console.WriteLine($"Result: {l2}{l1}"));

    task2.Wait();
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
