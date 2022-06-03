string a = " ";
while (a.Length > 0)
{
    try
    {
        Console.WriteLine("Введите действие -  \nCложение(+)\nВычитание(-)\nУмножение(*)\nДеление(/)");
        a = Console.ReadLine();
        Console.WriteLine();
        if (a.Length > 0)
        {
            Console.Write("Первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (a)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    double del = myDelegat(x, y);
                    Console.WriteLine($"Ответ:{del}\n");
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    double del1 = myDelegat1(x, y);
                    Console.WriteLine($"Ответ:{del1}\n");
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    double del2 = myDelegat2(x, y);
                    Console.WriteLine($"Ответ:{del2}\n");
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => { return b == 0 ? throw new DivideByZeroException() : c / b; };
                    double del3 = myDelegat3(x, y);
                    Console.WriteLine($"Ответ:{del3}\n");
                    break;
                default:
                    Console.WriteLine("Выберите из предложанного");
                    break;

            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

/// <summary>
/// Delegat for work with two number.
/// </summary>
/// <param name="a">first number</param>
/// <param name="b">secon number</param>
/// <returns></returns>
public delegate double MyDelegat(int a, int b);