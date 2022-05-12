Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = number / 10 % 10;
int result = firstDigit + secondDigit;
Console.WriteLine(result);