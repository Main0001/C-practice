string result = "";

try
{
    Console.WriteLine("Введите номер масти от 1 до 4: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер карты с 6 до 14: ");
    int k = Convert.ToInt32(Console.ReadLine());

    switch (k)
    {
        case 6:
            result += "шестёрка";
            break;
        case 7:
            result += "семёрка";
            break;
        case 8:
            result += "восьмёрка";
            break;
        case 9:
            result += "девятка";
            break;
        case 10:
            result += "десятка";
            break;
        case 11:
            result += "валет";
            break;
        case 12:
            result += "дама";
            break;
        case 13:
            result += "король";
            break;
        case 14:
            result += "туз";
            break;
    }

    switch (m)
    {
        case 1: 
            result += " пик";
            break;
        case 2: 
            result += " трефы";
            break;
        case 3: 
            result += " бубен";
            break;
        case 4: 
            result += " червы";
            break;
    }

    Console.WriteLine(result);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}