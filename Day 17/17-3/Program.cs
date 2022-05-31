try
{
    string path = @"file.txt";

    using (StreamReader sr = new StreamReader(path))
    {
        PrintFile(sr);
    }

    string[] str = StringSplit(path);
    Console.WriteLine(str.Length);

    int[] arr = CharCount(str);
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"В {i} строке {arr[i]} символов");

    DeleteLast(str);

    Console.Write("Введите начальную строку: ");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конечную строку: ");
    int end = Convert.ToInt32(Console.ReadLine());

    PrintFromRange(str, start, end);

    StringMax(str);

    Console.Write("Введите букву: ");
    char letter = Convert.ToChar(Console.ReadLine());

    PrintFromLetter(str, letter);

    PrintInFile(str);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void PrintFile(StreamReader sr)
{
    Console.WriteLine(sr.ReadToEnd());
}

string[] StringSplit(string path)
{
    string[] str = File.ReadAllLines(path);
    return str;
}

int[] CharCount(string[] str)
{
    int[] arr = new int[str.Length];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = str[i].Length;
    return arr;
}

void DeleteLast(string[] str)
{
    string[] st = new string[str.Length - 1];
    for (int i = 0; i < st.Length; i++)
        st[i] = str[i];
    File.WriteAllLines("out.txt", st);
}

void PrintFromRange(string[] str, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.WriteLine(str[i]);
    }
}

void StringMax(string[] str)
{
    Console.WriteLine(str.Select((x) => x.Length).Max());
}

void PrintFromLetter(string[] str, char letter)
{
    for (int i = 0; i < str.Length; i++)
        if (str[i][0] == letter)
            Console.WriteLine(str[i]);
}

void PrintInFile(string[] str)
{
    Array.Reverse(str);
    StreamWriter sw = new StreamWriter("out1.txt");
    foreach (string st in str)
    {
        sw.WriteLine(st);
    }
    sw.Close();
}