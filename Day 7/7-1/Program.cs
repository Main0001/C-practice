try
{
    Console.Write("Enter line: ");
    string text = Console.ReadLine().ToLower();
    text = text.Replace(" ", "");
    if (text == Reverse(text))
    {
        Console.WriteLine("True");
    } else { Console.WriteLine("False"); }
}
catch (Exception e)
{
    Console.WriteLine($"Some error ({e})");
}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}