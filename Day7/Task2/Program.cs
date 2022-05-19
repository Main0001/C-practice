Console.Write("Введите текст: ");

try
{
    string str = Console.ReadLine();

    string[] subs = str.Split(' ');

    var items = subs.Where(x => x[0] == x[x.Length - 1]);
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}