double result = 0;
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("d = ");
double d = Convert.ToDouble(Console.ReadLine());

try
{
    result = a / b + c / d;
    Console.WriteLine($"{a} / {b} + {c} / {d} = {Math.Round(result, 2)}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}