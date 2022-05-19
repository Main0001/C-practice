try
{
    Console.Write("Enter line: ");
    string line = Console.ReadLine().ToLower();
    string[] words = line.Split(' ');
    if (words.Length >= 2)
    {
        var temp = words[words.Length - 1];
        words[words.Length - 1] = words[0];
        words[0] = temp;

        line = String.Join(' ', words);


        Console.WriteLine(line);
        if (words.Length >= 3)
        {
            line = line.Remove(line.LastIndexOf(' '), 1);
            Console.WriteLine(line);

            words = line.Split(' ');
            words[2] = Reverse(words[2]);

            line = String.Join(' ', words);
            Console.WriteLine(line);
        }
        else { Console.WriteLine("Less then 3 words!"); }
    }
    if (words.Length >= 1 && words[0].Length >= 2)
    {
        line = line.Substring(2);
        Console.WriteLine(line);
    }
    else
    {
        Console.WriteLine("First word lower then 2 chars!");
    }

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