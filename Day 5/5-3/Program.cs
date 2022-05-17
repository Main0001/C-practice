using System.Collections.Generic;

Dictionary<int, string> people = new Dictionary<int, string>();
Console.WriteLine(people.GetType);
while (true)
{
    try
    {
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Enter D1: ");
        int D1 = int.Parse(Console.ReadLine());
        AddLeftDigit(D1, ref K);
        Console.WriteLine(K);
        Console.Write("Enter D2: ");
        int D2 = int.Parse(Console.ReadLine());
        AddLeftDigit(D2, ref K);
        Console.WriteLine(K);
        break;
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Sorry, it's format exception (Error: {e})");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Divide by zero! {e}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Some error (Error: {e})");
    }
}


static void AddLeftDigit(int D, ref int K)
{
    if (D <= 0 || D > 9 || K <= 0)
        throw new ArgumentException("Неверное значение параметров");
    int n = K;
    while (n != 0)
    {
        n /= 10;
        D *= 10;
    }
    K += D;
}


