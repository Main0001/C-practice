try
{
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();
    var pos = input.IndexOf(',');
    int count = 0;

    if (pos > 0)
    {
        for (int i = 0; i < pos; i++)
        {
            if (input[i] == 'a')
            {
                count += 1;
                Console.WriteLine(input[i]);
            }
        }
    }
    else
    {
        Console.WriteLine("Запятые отсутствуют");
    }
    Console.WriteLine(count);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}