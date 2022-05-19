try
{
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();
    int carent = default;
    int max = default;

    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsDigit(input[i]))
        {
            carent += 1;
        }
        else if (carent > max)
        {
            max = carent;
            carent = 0;
        }
        
    }
    if (carent > max)
    {
        max = carent;
    }

    Console.WriteLine(max);
    Console.ReadLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}