Console.Write("Введите строку: ");
string str = Console.ReadLine();
char symbol = str[1];
var result = str.ToArray();
result[1] = str[2];
result[2] = symbol;
Console.WriteLine(result);