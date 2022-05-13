try
{
    Console.WriteLine("Введите количество сантиметров (целочисленное число)");
    var data = int.Parse(Console.ReadLine());
    var result = data / 100;
    Console.WriteLine($"result = {result}"); 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}