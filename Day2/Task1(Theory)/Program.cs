void Sum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine("Сумма = " + sum);
}

void Sub(int a, int b)
{
    int sub = a - b;
    Console.WriteLine("Разность = " + sub);
}

void Mult(int a, int b)
{
    int mult = a * b;
    Console.WriteLine("Произведение = " + mult);
}

void Div(int a, int b)
{
    int div = a / b;
    Console.WriteLine("Частное = " + div);
}

try
{
    Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("b = ");
    int b = Convert.ToInt32(Console.ReadLine());

    Sum(a, b);
    Sub(a, b);
    Mult(a, b);
    Div(a, b);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}