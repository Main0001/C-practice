try
{
    Console.Write("Введите первое двоичое число: ");
    string bitStr = Console.ReadLine();

    Console.Write("Введите второе двоичное число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    bool right = false;
    for (int i = 0; i < bitStr.Length; i++)
    {
        if (bitStr[i] == '1' || bitStr[i] == '0')
        {
            continue;
        }
        else
        {
            Console.WriteLine("Введена неверная строка");
            right = true;
            break;
        }
    }

    if (!right)
    {
        BitString clas = new BitString(bitStr);
        clas.Sum(b);
        clas.Sub(b);
        clas.Mul(b);
        clas.Div(b);
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class BitString
{
    public string bitStr;

    public BitString(string bitStr)
    {
            this.bitStr = bitStr;
    }

    public static int ToDec(string bin)
    {
        var result = 0;
        for (int i = 0; i < bin.Length; ++i)
        {
            if (bin[bin.Length - i - 1] == '1')
            {
                result += (int)Math.Pow(2, i);
            }
        }
        return result;
    }

    public void Sum(int b)
    {
        int bits = ToDec(bitStr);
        string second = Convert.ToString(b);
        b = ToDec(second);
        int summ = bits + b;
        Console.WriteLine($"Результат сложения: {Convert.ToString(summ, 2)}");
    }

    public void Sub(int b)
    {
        int bits = ToDec(bitStr);
        string second = Convert.ToString(b);
        b = ToDec(second);
        int subs = bits - b;
        if (bits >= b)
            Console.WriteLine($"Результат вычитания: {Convert.ToString(subs, 2)}");
        else
            Console.WriteLine($"Первое число должно быть меньше второго");
    }

    public void Mul(int b)
    {
        int bits = ToDec(bitStr);
        string second = Convert.ToString(b);
        b = ToDec(second);
        int mult = bits * b;
        Console.WriteLine($"Результат умножения: {Convert.ToString(mult, 2)}");
    }

    public void Div(int b)
    {
        int bits = ToDec(bitStr);
        string second = Convert.ToString(b);
        b = ToDec(second);
        int div = bits / b;
        Console.WriteLine($"Результат деления: {Convert.ToString(div, 2)}");
    }
}