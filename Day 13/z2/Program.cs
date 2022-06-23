string a = " ";
while (a.Length > 0)
{
    try
    {
        Console.WriteLine("Введите действие -  \nCложение(+Sum)\nВычитание(-Sub)\nУмножение(*Mul)\nДеление(/Div)");
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
                case "Sum":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    double del = myDelegat(x, y);
                    Console.WriteLine($"Ответ:{del}\n");
                    break;
                case "Sub":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    double del1 = myDelegat1(x, y);
                    Console.WriteLine($"Ответ:{del1}\n");
                    break;
                case "Mul":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    double del2 = myDelegat2(x, y);
                    Console.WriteLine($"Ответ:{del2}\n");
                    break;
                case "Div":
                    MyDelegat myDelegat3 = (c, b) => { return b == 0 ? throw new DivideByZeroException() : c / b; };
                    double del3 = myDelegat3(x, y);
                    Console.WriteLine($"Ответ:{del3}\n");
                    break;
                default:
                    Console.WriteLine("Выберите из предложенного");
                    break;

            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

public delegate double MyDelegat(int a, int b);
