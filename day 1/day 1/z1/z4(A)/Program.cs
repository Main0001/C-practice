try
{
    Console.Write("x1= ");
    var x1 = double.Parse(Console.ReadLine());
    Console.Write("x2= ");
    var x2 = double.Parse(Console.ReadLine());
    Console.Write("y1= ");
    var y1 = double.Parse(Console.ReadLine());
    Console.Write("y2= ");
    var y2 = double.Parse(Console.ReadLine());

    var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"result = {result}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
