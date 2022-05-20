using System.Text.RegularExpressions;

try
{
    Console.Write("Введите строку: ");
    string text = Console.ReadLine();

    Regex task = new Regex(@"\d");
    bool hesDigits = task.IsMatch(text);

    string result = hesDigits ? "Есть цифры" : "Нет цифр";
    Console.WriteLine(result);
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}