using System.Text.RegularExpressions;

try
{
    Console.Write("Введите строку:");
    string text = Console.ReadLine();

    Regex task = new Regex(@"(<html>|<form>|<h1>)(.*?)(</html>|</form>|</h1>)"); //Выдает False при неправильном написании тега (<<form>> и т.д.)
    bool hesDigits = task.IsMatch(text);

    var result = hesDigits ? "True" : "False";
    Console.WriteLine($"result = {result}");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}