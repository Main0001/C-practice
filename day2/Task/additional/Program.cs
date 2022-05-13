using System.Text;

try
{
    
    Console.Write("Введите число: ");
    string str = Console.ReadLine();

    var result =new string(str.Where(c => char.GetNumericValue(c) % 2!=0).ToArray());

    Console.WriteLine(result);
    var strBuilder = new StringBuilder();
    foreach (var symbol in str)
    {
        var digit=char.GetNumericValue(symbol);
        if (digit % 2 !=0)
        {
            strBuilder.Append(symbol);
        }
    }
    Console.WriteLine(strBuilder.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
