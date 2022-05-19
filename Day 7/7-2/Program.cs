string inputStr = Console.ReadLine();

if (!IsCorrectString(inputStr))
{
    Console.WriteLine("Необходимо ввести только цифры и буквы");

    return;
}
int sum = 0;

for (int i = 0; i < inputStr.Length; i++)
{
    if (char.IsDigit(inputStr[i]))
    {
        sum += Convert.ToInt32(inputStr[i].ToString());
    }
}
if (sum == inputStr.Length)
{
    Console.WriteLine("Сумма цифр в строке = длине строки");
}
else
{
    Console.WriteLine("Сумма цифр в строке != длине строки");
}

static bool IsCorrectString(string inputStr)
{
    for (int i = 0; i < inputStr.Length; i++)
    {
        if (!char.IsLetterOrDigit(inputStr[i]))
        {
            return false;
        }
    }
    return true;
}