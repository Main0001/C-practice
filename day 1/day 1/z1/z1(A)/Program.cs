int firstNumber;
int secondNumber;
int result;

try
{
    Console.Write("a = ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("b = ");
    secondNumber = int.Parse(Console.ReadLine());

    result = firstNumber + secondNumber;
    Console.WriteLine($"result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
