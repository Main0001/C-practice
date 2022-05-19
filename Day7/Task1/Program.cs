Console.Write("Введите текст: ");

try
{
    string str = Console.ReadLine();

    string[] subs = str.Split(' ');

    int counter = 0;
    foreach (var sub in subs)
    {
        counter = 0;
        for (int i = 0; i < sub.Length; i++)
        {
            if (Char.IsDigit(sub[i]))
                counter = 1;
        }
        if (counter == 1)
            Console.WriteLine(sub);      
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}