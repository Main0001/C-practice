using System.Diagnostics;

try
{
    Console.Write("Введите строку: ");
    string text = Console.ReadLine();

    Stopwatch sw = Stopwatch.StartNew();

    var task1 = Task.Run(() =>
    {
        char[] arr = text.ToCharArray();
        char temp = arr[1];
        arr[1] = arr[2];
        arr[2] = temp;
        text = String.Join("", arr);
    });

    var task2 = new Task(() =>
    {
        char[] arr = text.ToCharArray();
        char temp = arr[1];
        arr[1] = arr[2];
        arr[2] = temp;
        text = String.Join("", arr);
    });

    task2.Start();

    var task3 = Task.Factory.StartNew(() =>
    {
        char[] arr = text.ToCharArray();
        char temp = arr[1];
        arr[1] = arr[2];
        arr[2] = temp;
        text = String.Join("", arr);
    });

    task1.Wait();
    Console.WriteLine($"Полученная строка: {text}");
    task2.Wait();
    Console.WriteLine($"Полученная строка: {text}");
    task3.Wait();
    Console.WriteLine($"Полученная строка: {text}");

    sw.Stop();
    Console.WriteLine(sw.Elapsed);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}