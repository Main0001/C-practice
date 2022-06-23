using System.Text.RegularExpressions;

try
{
    Console.Write("Enter:");
    string text = Console.ReadLine();

    Regex task = new Regex(@"([A-zА-я]+)([\-])");
    MatchCollection hesDigits = task.Matches(text);

    if (hesDigits.Count == 0)
    {
        Console.WriteLine("Empty");
    }
    else
    {
        foreach (Match item in hesDigits)
        {
            Console.WriteLine(item.Groups[1]);
        }
    }
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}