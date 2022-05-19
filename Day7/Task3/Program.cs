Console.Write("Введите текст: ");

try
{
    string str = Console.ReadLine();

    string[] subs = str.Split(' ');

    subs = ChangePlace(subs);
    Console.Write("Первое слово меняется с последним:");
    foreach (var value in subs)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();

    subs = StringJoin(subs);
    Console.Write("Второе и третье слова склеены:");
    foreach (var value in subs)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();

    ReverseOutput(subs);
    Console.WriteLine();

    subs = Cut(subs);
    Console.Write("В первом слове вырезаны 2 первые буквы:");
    foreach (var value in subs)
    {
        Console.Write(value + " ");
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string[] ChangePlace(string[] subs)
{
    string temp = subs[0];
    subs[0] = subs[subs.Length-1];
    subs[subs.Length-1] = temp;
    return subs;
}

string[] StringJoin(string[] subs)
{
    subs[1] += subs[2];
    return subs;
}

void ReverseOutput(string[] subs)
{
    char[] charArray = subs[2].ToCharArray();
    Array.Reverse(charArray);
    subs[2] = new string(charArray);
    Console.Write($"Третье слово в обратном порядке: {subs[2]}");
}

string[] Cut(string[] subs)
{
    subs[0] = subs[0].Remove(0, 2);
    return subs;
}