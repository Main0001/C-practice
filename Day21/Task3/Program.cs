try
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    var task1 = Task.Run(() =>
    {
        sum += number / 100 + ((number / 10) % 10);
    });

    Task task2 = task1.ContinueWith(t => Console.WriteLine($"Сумма первой и второй цифры числа {number} = {sum}"));

    task2.Wait();
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}