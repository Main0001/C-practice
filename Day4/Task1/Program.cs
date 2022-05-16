using System.Text;

try
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();

    number = ChangePlaces(number);

    Console.WriteLine(number);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string ChangePlaces(string number)
{
    if (number.Length == 2)
    {
        StringBuilder sb = new StringBuilder(number);
        char elem = sb[0];
        sb[0] = sb[1];
        sb[1] = elem;
        number = sb.ToString();
    }
    return number;
}