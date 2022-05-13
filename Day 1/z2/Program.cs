string result;
Console.WriteLine("Enter 3-digit number: ");
string num = Console.ReadLine();
result = num.Substring(1, num.Length - 1) + num[0];
Console.WriteLine(result);
