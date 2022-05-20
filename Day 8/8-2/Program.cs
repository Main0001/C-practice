using System.Text.RegularExpressions;

namespace L8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string text = Console.ReadLine();
            Console.WriteLine(text);

            Regex task = new Regex(@"\d");
            bool hesDigits = task.IsMatch(text);

            string result = hesDigits ? "Есть цифры" : "Нет цифр";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
