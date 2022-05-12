const float X = 1.0668f;

Console.Write("Введите расстояние в вёрстах: ");
try
{
    double distance = Convert.ToDouble(Console.ReadLine());
    double result = distance * X;
    Console.WriteLine($"{distance} верст(а/ы) - это {Math.Round(result, 2)} км");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}