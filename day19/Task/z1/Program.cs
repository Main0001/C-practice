try
{
    Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine();

    var textStack = new Stack<char>();

    for (int i = 0; i < str.Length; i++)
        textStack.Push(str[i]);

    Console.WriteLine(EraseCharacters(textStack));
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string EraseCharacters(Stack<char> text)
{
    int counter = 0;
    string str = string.Empty;

    while (text.Count > 0)
    {
        char c = text.Pop();
        if (c == '#')
            counter++;
        else if (counter > 0)
            counter--;
        else str += c;
    }
    char[] chars = new char[str.Length];
    chars = str.Select(x => x).ToArray();
    Array.Reverse(chars);
    str = new string(chars);

    return str;
}