try
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();

    Message msg = ChangeReg; //присваиваем метод делегату
    msg += Substr; //добавляем метод делегату, делагат выполняет методы в цепочке (по очереди)
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
    Console.WriteLine(str.Substring(2)); //удаляет первые два символа строки
}

void Separate(string str)
{
    string[] words = str.Split(' ');

    foreach (string word in words)
        Console.WriteLine(word);
}

delegate void Message(string str);