try
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();

    Message msg = ChangeReg;
    msg += Substr;
    msg += Separate;

    msg(str);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void ChangeReg(string str)
{
    Console.WriteLine(str.ToUpper());
}

void Substr(string str)
{
    Console.WriteLine(str.Substring(2));
}

void Separate(string str)
{
    string[] words = str.Split(' ');

    foreach (string word in words)
        Console.WriteLine(word);
}

/// <summary>
/// Delegat for work with string
/// </summary>
/// <param name="str">some text</param>
delegate void Message(string str);